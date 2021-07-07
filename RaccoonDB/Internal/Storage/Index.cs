using System;
using System.IO;
using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;

namespace RaccoonDB.Internal.Storage
{
    public class Index
    {
        private readonly string _directory;
        private readonly string _tableName;
        private readonly string _indexName;
        private readonly RaccoonDbDataType _dataType;

        public Index(string directory, string tableName, string indexName, bool unique, RaccoonDbDataType dataType)
        {
            _directory = directory;
            _tableName = tableName;
            _indexName = indexName;
            _dataType = dataType;
        }
    }
}