using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using CSharpTest.Net.Collections;
using RaccoonDB.Interface;

namespace RaccoonDB.Internal.Storage
{
    public struct TableField
    {
        internal object Value { get; set; }
        internal RaccoonDbDataType DataType { get; set; }
    }

    internal class TableReader
    {
        private readonly BPlusTree<Guid, string> _dataTree;
        private readonly TableInformation _tableInformation;
        private Dictionary<string, RaccoonDbDataType> _columnTypes = new();
        
        internal TableReader(BPlusTree<Guid, string> dataTree, TableInformation tableInformation)
        {
            _dataTree = dataTree;
            _tableInformation = tableInformation;
            
            foreach (var columnInformation in _tableInformation.Columns)
            {
                _columnTypes[columnInformation.Name] = columnInformation.Type;
            }
        }

        public TableField? GetValue(Guid guid, string fieldName)
        {
            var row = GetRow(guid);
            if (row == null) return null;
            return new TableField
            {
                Value = row[fieldName],
                DataType = _columnTypes[fieldName],
            };
        }

        public dynamic? GetRow(Guid guid)
        {
            var json = _dataTree[guid];
            if (json == null) return null;
            var column = JsonSerializer.Deserialize<dynamic>(json)!;
            return column;
        }

        public void Iterate(Action<Guid, TableField[]> action, string[]? fieldNames = null)
        {
            fieldNames ??= _columnTypes.Keys.ToArray();

            foreach (var guid in _dataTree.Keys)
            {
                var row = GetRow(guid);
                if(row == null)
                    continue;
                
                var fields = new TableField[fieldNames.Length];
                for (var i = 0; i < fieldNames.Length; i++)
                {
                   fields[i] = new TableField
                   {
                       Value = row[fieldNames[i]],
                       DataType = _columnTypes[fieldNames[i]],
                   };
                }
                action.Invoke(guid, fields);
            }
        }

        public ResultRow? GetRow(Guid guid, string[] columns)
        {
            var row = GetRow(guid);
            if (row == null)
                return null;
            
            var columnValues = new object[columns.Length];
            
            for (var i = 0; i < columns.Length; i++)
            {
                columnValues[i] = row[columns[i]];
            }
            
            return new ResultRow(columnValues);
        }
    }
}