using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;
using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Storage
{
    public sealed class Table : IDisposable
    {
        // ReSharper disable once ClassNeverInstantiated.Local
        public class TableInformation
        {
            public string TableName { get; set; } = null!;
            public List<ColumnInformation> Columns { get; set; } = new();
            public List<IndexInformation> Indexes { get; set; } = new();

            // ReSharper disable once ClassNeverInstantiated.Local
            public class ColumnInformation
            {
                public string Name { get; set; } = null!;
                public string Type { get; set; } = null!;
                public bool Unique { get; set; }
                public bool NotNull { get; set; }
                public bool PrimaryKey { get; set; }
                public bool ForeignKey { get; set; }
                public string? ForeignTable { get; set; }
                public string? ForeignColumn { get; set; }
                public bool Auto { get; set; }
            }

            // ReSharper disable once ClassNeverInstantiated.Local
            public class IndexInformation
            {
                public string Name { get; set; } = null!;
                public bool Unique { get; set; }
                public List<string> ColumnNames { get; set; } = new();
            }
        }
        
        private readonly string _name;
        private readonly string _directory;

        private TableInformation _tableInformation;
        
        private FileStream _dataStream;

        private Table(string name, string directory, TableInformation tableInformation, FileStream dataStream)
        {
            _name = name;
            _directory = directory;
            _tableInformation = tableInformation;
            _dataStream = dataStream;
        }

        public static Table OpenTable(string tableName, string dbDirectory)
        {
            var location = Path.Combine(dbDirectory, tableName);
            
            var infoFilePath = Path.Combine(location, "table.info");
            var tableInformation = JsonSerializer.Deserialize<TableInformation>(File.ReadAllText(infoFilePath))
                                ?? throw new Exception("Deserialization of table information failed.");
            
            var dataFilePath = Path.Combine(location, "table.data");
            var dataStream = File.Open(dataFilePath, FileMode.Open);

            return new Table(tableName, dbDirectory, tableInformation, dataStream);
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
                Columns = model.Columns.Select(x => new TableInformation.ColumnInformation
                {
                    Auto = x.AutoValue,
                    Name = x.ColumnName,
                    Type = x.ColumnType,
                    Unique = x.Unique,
                    ForeignColumn = x.ForeignColumnName,
                    ForeignKey = x.ForeignKey,
                    ForeignTable = x.ForeignTableName,
                    NotNull = x.NotNull,
                    PrimaryKey = x.PrimaryKey,
                }).ToList(),
            };
            
            var dataFilePath = Path.Combine(location, "table.data");
            var dataStream = File.Create(dataFilePath);

            var table = new Table(model.TableName, dbDirectory, tableInformation, dataStream);

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
            
        }

        public void DropIndex(DropIndexModel model)
        {
            if (_tableInformation.Indexes.All(x => x.Name != model.IndexName))
                throw new RacconDbSchemaException($"index {model.IndexName} not found on table {model.TableName}");
        }

        public void ExplainIndex(ExplainIndexModel model)
        {
            
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
        
        public Task<IEnumerable<ResultRow>> ScanAsync()
        {
            return Task.FromResult(Enumerable.Empty<ResultRow>());
        }

        public void Drop()
        {
            _dataStream.Close();
            Directory.Delete(Path.Combine(_directory, _name), true);
        }

        public void Truncate()
        {
            _dataStream.SetLength(0);
            _dataStream.Flush();
        }

        public TableInformation Explain() =>
            new()
            {
                TableName = _tableInformation.TableName,
                Columns = _tableInformation.Columns.Select(x => new TableInformation.ColumnInformation
                {
                    Auto = x.Auto,
                    Name = x.Name,
                    Type = x.Type,
                    Unique = x.Unique,
                    ForeignColumn = x.ForeignColumn,
                    ForeignKey = x.ForeignKey,
                    ForeignTable = x.ForeignTable,
                    NotNull = x.NotNull,
                    PrimaryKey = x.PrimaryKey,
                }).ToList(),
                Indexes = _tableInformation.Indexes.Select(x => new TableInformation.IndexInformation
                {
                    Name = x.Name,
                    Unique = x.Unique,
                    ColumnNames = x.ColumnNames.ToList(),
                }).ToList(),
            };

        public void Dispose()
        {
            _dataStream.Dispose();
        }
    }
}