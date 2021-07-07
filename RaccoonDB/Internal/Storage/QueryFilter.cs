using System;
using System.Collections.Generic;

namespace RaccoonDB.Internal.Storage
{
    internal class QueryFilter
    {
        public string ColumnName { get; set; }

        public IEnumerable<Guid> Evaluate(TableReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}