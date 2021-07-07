using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Storage
{
    public class RaccoonDbStorageEngine : IRaccoonDbStorageWriter
    {
        public class DbDescriptor
        {
            public List<string> Tables { get; set; } = new();
        }
        
        private readonly string _dbDirectory;
        private readonly Dictionary<string, Table> _tables = new();
        private DbDescriptor _descriptor;

        public RaccoonDbStorageEngine(string dbDirectory)
        {
            _dbDirectory = dbDirectory;
            
            _descriptor = LoadOrCreateDbDescriptor();
            LoadTables();
        }

        private DbDescriptor LoadOrCreateDbDescriptor()
        {
            var descriptorPath = Path.Combine(_dbDirectory, "db.info");
            if (!File.Exists(descriptorPath))
            {
                _descriptor = new DbDescriptor();
                WriteDbInfo();
            }
            else
            {
                _descriptor = JsonSerializer.Deserialize<DbDescriptor>(File.ReadAllText(descriptorPath))
                              ?? throw new RacconDbSchemaException("Could not load db descriptor");
            }

            return _descriptor;
        }

        private void WriteDbInfo()
        {
            var descriptorPath = Path.Combine(_dbDirectory, "db.info");
            File.WriteAllText(descriptorPath, JsonSerializer.Serialize(_descriptor));
        }
        
        private void LoadTables()
        {
            foreach (var tableName in _descriptor.Tables)
            {
                LoadTable(tableName);
            }
        }

        private void LoadTable(string tableName)
        {
            _tables[tableName] = Table.OpenTable(tableName, _dbDirectory);
        }

        public void CreateTable(CreateTableModel model)
        {
            var exists = _tables.ContainsKey(model.TableName);
            
            if (model.IfNotExists && exists)
                return;
            
            if (exists)
                throw new RacconDbSchemaException($"duplicate table name '{model.TableName}'");

            _tables[model.TableName] = Table.CreateTable(model, _dbDirectory);
            _descriptor.Tables.Add(model.TableName);
            
            WriteDbInfo();
        }

        public void AddColumn(AddColumnModel model)
        {
            throw new System.NotImplementedException();
        }

        public void DropColumn(DropColumnModel model)
        {
            throw new System.NotImplementedException();
        }

        public void AlterColumn(AlterColumnModel model)
        {
            throw new System.NotImplementedException();
        }

        public void DropTable(DropTableModel model)
        {
            var exists = _tables.ContainsKey(model.TableName);
            
            if(model.IfExists && !exists)
                return;
            
            if(!exists)
                throw new RacconDbSchemaException($"unknown table name '{model.TableName}'");

            _tables.Remove(model.TableName, out var table);
            _descriptor.Tables.Remove(model.TableName);

            table!.Drop();
            
            WriteDbInfo();
        }

        public void TruncateTable(TruncateModel model)
        {
            var exists = _tables.ContainsKey(model.TableName);
            if(!exists)
                throw new RacconDbSchemaException($"unknown table name '{model.TableName}'");
            
            _tables[model.TableName].Truncate();
        }

        public void CreateIndex(CreateIndexModel model)
        {
            throw new System.NotImplementedException();
        }

        public void DropIndex(DropIndexModel model)
        {
            throw new System.NotImplementedException();
        }

        public TableInformation ExplainTable(ExplainTableModel model)
        {
            var exists = _tables.ContainsKey(model.TableName);
            if(!exists)
                throw new RacconDbSchemaException($"unknown table name '{model.TableName}'");

            return _tables[model.TableName].Explain();
        }

        public IndexInformation ExplainIndex(ExplainIndexModel model)
        {
            var exists = _tables.ContainsKey(model.TableName);
            if(!exists)
                throw new RacconDbSchemaException($"unknown table name '{model.TableName}'");
            
            return _tables[model.TableName].ExplainIndex(model);
        }
    }
}