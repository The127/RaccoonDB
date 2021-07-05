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
            
        }

        public ResultSet ExecuteSql(string sql, object[] @params)
        {
            if (!_queryCache.TryGetCompiledQuery(sql, out var compiledQuery))
            {
                compiledQuery = _queryCompiler.Compile(sql);
            }

            return compiledQuery.Execute(@params);
        }
    }
}