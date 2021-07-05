namespace RaccoonDB.Internal.Querying
{
    public class SqlQueryCache
    {
        public bool TryGetCompiledQuery(string sql, out CompiledQuery compiledQuery)
        {
            //TODO
            compiledQuery = null;
            return false;
        }

        public void CacheCompiledQuery(string sql, CompiledQuery compiledQuery)
        {
            //TODO
        }
    }
}