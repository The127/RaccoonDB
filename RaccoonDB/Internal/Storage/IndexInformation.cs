using System.Collections.Generic;

namespace RaccoonDB.Internal.Storage
{
    public class IndexInformation
    {
        public string Name { get; set; } = null!;
        public bool Unique { get; set; }
        public List<string> ColumnNames { get; set; } = new();
    }
}