using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;
using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Storage
{
    internal sealed class Table : IDisposable
    {
        
        
        private readonly string _name;
        private readonly string _directory;

        private readonly TableInformation _tableInformation;
        private BPlusTree<Guid, string> _dataTree;

        private Dictionary<string, Index> _indices = new();
        private TableReader _reader;

        private Table(string name, string directory, TableInformation tableInformation)
        {
            _name = name;
            _directory = directory;
            _tableInformation = tableInformation;
            
            BPlusTree<Guid, string>.Options options = new(PrimitiveSerializer.Guid, PrimitiveSerializer.String)
            {
                CreateFile = CreatePolicy.IfNeeded,
                FileName = Path.Combine(directory, name, "table.data"),
            };
            
            _dataTree = new BPlusTree<Guid, string>(options);
            _reader = new TableReader(_dataTree, _tableInformation);
        }

        public static Table OpenTable(string tableName, string dbDirectory)
        {
            var location = Path.Combine(dbDirectory, tableName);
            
            var infoFilePath = Path.Combine(location, "table.info");
            var tableInformation = JsonSerializer.Deserialize<TableInformation>(File.ReadAllText(infoFilePath))
                                ?? throw new Exception("Deserialization of table information failed.");

            return new Table(tableName, dbDirectory, tableInformation);
        }

        public static Table CreateTable(CreateTableModel model, string dbDirectory)
        {
            if (model.Columns.All(x => !x.PrimaryKey))
                throw new RacconDbSchemaException($"table {model.TableName} requires at least one column with the primary key constraint");

            var location = Path.Combine(dbDirectory, model.TableName);
            Directory.CreateDirectory(location);

            var tableInformation = new TableInformation
            {
                TableName = model.TableName,
                Columns = model.Columns.Select(x => new ColumnInformation
                {
                    Auto = x.AutoValue,
                    Name = x.ColumnName,
                    TypeName = x.ColumnType,
                    Unique = x.Unique,
                    ForeignColumn = x.ForeignColumnName,
                    ForeignKey = x.ForeignKey,
                    ForeignTable = x.ForeignTableName,
                    NotNull = x.NotNull,
                    PrimaryKey = x.PrimaryKey,
                }).ToList(),
            };
            
            var table = new Table(model.TableName, dbDirectory, tableInformation);

            table.WriteInfoFile();

            var primaryKeyIndex = new CreateIndexModel
            {
                Unique = true,
                TableName = model.TableName,
                IndexName = "$ix_primary_key",
            };

            foreach (var tableColumnModel in model.Columns)
            {
                table.AddColumn(new AddColumnModel
                {
                    TableName = model.TableName,
                    ColumnModel = tableColumnModel
                });

                if (tableColumnModel.PrimaryKey)
                {
                    primaryKeyIndex.Columns.Add(tableColumnModel.ColumnName);
                }
            }
            
            table.CreateIndex(primaryKeyIndex);
            
            return table;
        }

        private void WriteInfoFile()
        {
            var location = Path.Combine(_directory, _tableInformation.TableName);
            var infoFilePath = Path.Combine(location, "table.info");
            var tableInfoJson = JsonSerializer.Serialize(_tableInformation);
            File.WriteAllText(infoFilePath, tableInfoJson);
        }

        public void CreateIndex(CreateIndexModel model)
        {
            var index = new Index(_directory,
                _name,
                model.IndexName,
                model.Unique,
                model.Columns[0],
                _tableInformation.Columns.First(x => x.Name == model.Columns[0]).Type, 
                _reader);
            
            _tableInformation.Indexes.Add(new IndexInformation
            {
                Name = model.IndexName,
                Unique = model.Unique,
                ColumnNames = model.Columns.ToList(),
            });
            
            _indices[model.Columns[0]] = index;
            
            WriteInfoFile();
        }

        public void DropIndex(DropIndexModel model)
        {
            if (_tableInformation.Indexes.All(x => x.Name != model.IndexName))
                throw new RacconDbSchemaException($"index {model.IndexName} not found on table {model.TableName}");

            var indexIndex = _tableInformation.Indexes.FindIndex(x => x.Name == model.IndexName);
            _tableInformation.Indexes.RemoveAt(indexIndex);

            var index = _indices[model.IndexName];
            index.Drop();
            
            WriteInfoFile();
        }

        public IndexInformation ExplainIndex(ExplainIndexModel model)
        {
            if (_tableInformation.Indexes.All(x => x.Name != model.IndexName))
                throw new RacconDbSchemaException($"index {model.IndexName} not found on table {model.TableName}");

            return _tableInformation.Indexes.Select(x => new IndexInformation
            {
                Name = x.Name,
                Unique = x.Unique,
                ColumnNames = x.ColumnNames.ToList(),
            }).First(x => x.Name == model.IndexName);
        }

        public void AddColumn(AddColumnModel model)
        {
            
        }

        public void AlterColumn(AlterColumnModel model)
        {
            
        }

        public void DropColumn(DropColumnModel model)
        {
            
        }
        
        public IEnumerable<ResultRow> Select(string[] columns, List<QueryFilter> queryFilters)
        {
            var set = queryFilters.First().Evaluate(_reader).ToHashSet();
            foreach (var queryFilter in queryFilters.Skip(1))
            {
                var containedGuids = queryFilter.Evaluate(_reader);
                set.IntersectWith(containedGuids);
                
                if(!set.Any())
                    yield break;
            }
            
            foreach (var guid in set)
            {
                var resultRow = _reader.GetRow(guid, columns);
                
                if(resultRow == null)
                    continue;
                
                yield return resultRow;
            }
        }

        public void Drop()
        {
            _dataTree.Dispose();
            _dataTree = null!;
            
            Directory.Delete(Path.Combine(_directory, _name), true);
        }

        public void Truncate()
        {
            _dataTree.Clear();
        }

        public TableInformation Explain() =>
            new()
            {
                TableName = _tableInformation.TableName,
                Columns = _tableInformation.Columns.Select(x => new ColumnInformation
                {
                    Auto = x.Auto,
                    Name = x.Name,
                    TypeName = x.TypeName,
                    Unique = x.Unique,
                    ForeignColumn = x.ForeignColumn,
                    ForeignKey = x.ForeignKey,
                    ForeignTable = x.ForeignTable,
                    NotNull = x.NotNull,
                    PrimaryKey = x.PrimaryKey,
                }).ToList(),
                Indexes = _tableInformation.Indexes.Select(x => new IndexInformation
                {
                    Name = x.Name,
                    Unique = x.Unique,
                    ColumnNames = x.ColumnNames.ToList(),
                }).ToList(),
            };

        public void Dispose()
        {
            _dataTree?.Dispose();
        }
    }
}