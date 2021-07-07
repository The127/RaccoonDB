using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Interface
{
    public class ResultSet
    {
        private List<ResultRow> _rows = new();

        private Dictionary<string, int> _columnNames = new();

        public ResultSet(params string[] columnNames)
        {
            foreach (var columnName in columnNames)
            {
                _columnNames[columnName] = _columnNames.Count;
            }
        }

        public void AddRow(ResultRow row)
        {
            _rows.Add(row);
            row.Parent = this;
        }

        public int ResolveColumnIndex(string columnName)
        {
            if (_columnNames.TryGetValue(columnName, out var index))
            {
                return index;
            }

            throw new RacconDbSchemaException($"no column {columnName} in result set");
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{nameof(ResultSet)}[\n");

            sb.Append("0: ")
                .Append(new ResultRow(_columnNames.Keys))
                .Append('\n');
            
            int index = 1;
            foreach (var tableRow in _rows)
            {
                sb.Append(index++)
                    .Append(": ")
                    .Append(tableRow)
                    .Append('\n');
            }
            
            return sb.Append(']').ToString();
        }
    }
}