using System.Collections.Generic;

namespace RaccoonDB.Internal.Storage
{
    public class TableInformation
    {
        public string TableName { get; set; } = null!;
        public List<ColumnInformation> Columns { get; set; } = new();
        public List<IndexInformation> Indexes { get; set; } = new();

        // ReSharper disable once ClassNeverInstantiated.Local
    }
}