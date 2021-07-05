using RaccoonDB.Interface;

namespace RaccoonDB.Internal.Querying
{
    public abstract class CompiledQuery
    {
        public abstract ResultSet Execute(object[] @params);
    }
}