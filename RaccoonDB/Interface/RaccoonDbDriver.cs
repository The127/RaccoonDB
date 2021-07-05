using System;
using RaccoonDB.Internal;

namespace RaccoonDB.Interface
{
    public sealed class RaccoonDbDriver
    {
        private readonly RaccoonDbDriverConfiguration _driverConfiguration;
        private RaccoonDbEngine _engine;


        public RaccoonDbDriver(string connecitonString)
            : this(connecitonString, new RaccoonDbDriverConfiguration())
        {
        }

        public RaccoonDbDriver(string connecitonString, RaccoonDbDriverConfiguration driverConfiguration)
        {
            _driverConfiguration = driverConfiguration;
            _engine = new RaccoonDbEngine(connecitonString);
        }

        public ResultSet ExecuteSql(string sql, params object[] @params)
        {
            return _engine.ExecuteSql(sql, @params);
        }
    }
}