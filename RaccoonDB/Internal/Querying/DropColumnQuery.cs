using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Querying
{
    public class DropColumnQuery : CompiledQuery
    {
        private readonly DropColumnModel _model;

        public DropColumnQuery(DropColumnModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params)
        {
            throw new System.NotImplementedException();
        }
    }
}