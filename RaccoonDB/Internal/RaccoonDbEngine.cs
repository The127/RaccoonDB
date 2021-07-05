using System;
using System.IO;
using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying;

namespace RaccoonDB.Internal
{
    public class RaccoonDbEngine
    {
        private SqlQueryCompiler _queryCompiler = new SqlQueryCompiler();
        private SqlQueryCache _queryCache = new SqlQueryCache();
        
        public RaccoonDbEngine(string connectionString)
        {
            if (!File.Exists(connectionString))
            {
                using var stream = File.Create(connectionString);
            }
        }

        public ResultSet ExecuteSql(string sql, object[] @params)
        {
            if (!_queryCache.TryGetCompiledQuery(sql, out var compiledQuery))
            {
                compiledQuery = _queryCompiler.Compile(sql);
                _queryCache.CacheCompiledQuery(sql, compiledQuery);
            }

            return compiledQuery.Execute(@params);
        }
    }
}