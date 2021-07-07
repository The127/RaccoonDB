using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using CSharpTest.Net.Collections;
using CSharpTest.Net.Serialization;

namespace RaccoonDB.Internal.Storage
{
    internal class Index
    {
        private readonly string _directory;
        private readonly string _tableName;
        private readonly string _indexName;
        private readonly bool _unique;
        private readonly string _columnName;
        private readonly RaccoonDbDataType _dataType;
        private readonly TableReader _reader;

        private readonly SortedList<TableField, Guid> _sortedList;

        public Index(string directory, string tableName, string indexName, bool unique, string columnName, RaccoonDbDataType dataType, TableReader reader)
        {
            _directory = directory;
            _tableName = tableName;
            _indexName = indexName;
            _unique = unique;
            _columnName = columnName;
            _dataType = dataType;
            _reader = reader;

            _sortedList = new SortedList<TableField, Guid>(dataType.GetComparer());

            InitializeIndex();
        }

        private void InitializeIndex()
        {
            _reader.Iterate((guid, fields) =>
            {
                _sortedList.Add(fields[0], guid);
            }, new []{_columnName});
        }

        public int Size => _sortedList.Count;

        public void Drop()
        {
        }
    }
}