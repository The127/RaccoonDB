using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaccoonDB.Interface
{
    public class ResultRow : IEnumerable<object>
    {
        private readonly List<object?> _items = new();
        internal ResultSet Parent { get; set; } = null!;

        public ResultRow(params object?[] items)
            : this(items.AsEnumerable())
        {
        }
        
        public ResultRow(IEnumerable<object?> items)
        {
            foreach (var item in items)
            {
                _items.Add(item);
            }
        }

        public object? GetItemAt(int index) =>
            _items[index];

        public object? GetItemAt(string columnName) =>
            _items[Parent.ResolveColumnIndex(columnName)];

        public object? this[int index] =>
            GetItemAt(index);

        public object? this[string columnName] =>
            GetItemAt(columnName);

        public IEnumerator<object> GetEnumerator() => _items.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            var sb = new StringBuilder($"{nameof(ResultRow)}[");
            sb.Append(string.Join(", ", _items.Select(x =>
            {
                if (x == null)
                {
                    return "null";
                }
                var stringRepresentation = x.ToString() ?? "";
                return @$"'{stringRepresentation
                    .Replace(",", "\\,")
                    .Replace("'", "\\'")}'";
            })));
            return sb.Append(']').ToString();
        }
    }
}