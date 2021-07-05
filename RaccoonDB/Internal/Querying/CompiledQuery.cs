using RaccoonDB.Interface;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public abstract class CompiledQuery
    {
        public abstract ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider);
    }
}