using System;
using RaccoonDB.Internal;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Interface
{
    public sealed class RaccoonDbDriver
    {
        private readonly RaccoonDbDriverConfiguration _driverConfiguration;
        private readonly RaccoonDbEngine _engine;
        private readonly IRaccoonDbStorageProvider _storageProvider;

        public RaccoonDbDriver(string connectionString)
            : this(connectionString, new RaccoonDbDriverConfiguration())
        {
        }

        public RaccoonDbDriver(string connectionString, RaccoonDbDriverConfiguration driverConfiguration)
        {
            _driverConfiguration = driverConfiguration;
            _engine = new RaccoonDbEngine();
            _storageProvider = new DefaultRaccoonDbStorageProvider(connectionString);
        }

        public ResultSet ExecuteSql(string sql, params object[] @params)
        {
            return _engine.ExecuteSql(sql, @params, _storageProvider);
        }
    }
}