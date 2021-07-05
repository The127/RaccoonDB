using System;
using RaccoonDB.Internal;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Interface
{
    public sealed class RaccoonDbDriver
    {
        private readonly RaccoonDbDriverConfiguration _driverConfiguration;
        private RaccoonDbEngine _engine;
        private IRaccoonDbStorageProvider _storageProvider = new DefaultRaccoonDbStorageProvider();

        public RaccoonDbDriver(string connectionString)
            : this(connectionString, new RaccoonDbDriverConfiguration())
        {
        }

        public RaccoonDbDriver(string connectionString, RaccoonDbDriverConfiguration driverConfiguration)
        {
            _driverConfiguration = driverConfiguration;
            _engine = new RaccoonDbEngine(connectionString);
        }

        public ResultSet ExecuteSql(string sql, params object[] @params)
        {
            return _engine.ExecuteSql(sql, @params, _storageProvider);
        }
    }
}