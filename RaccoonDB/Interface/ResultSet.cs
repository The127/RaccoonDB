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

        public int ResultSize => _rows.Count;
        public int AffectedRows { get; set; } = 0;

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
            var sb = new StringBuilder($"{nameof(ResultSet)}[{nameof(AffectedRows)}: '{AffectedRows}',\n");

            sb.Append("H: ")
                .Append(new ResultRow(_columnNames.Keys))
                .Append('\n');
            
            int index = 0;
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