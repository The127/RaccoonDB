using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Querying
{
    public class AlterColumnQuery : CompiledQuery
    {
        private readonly AlterColumnModel _model;

        public AlterColumnQuery(AlterColumnModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params)
        {
            throw new System.NotImplementedException();
        }
    }
}