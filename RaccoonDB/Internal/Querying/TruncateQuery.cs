using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Querying
{
    public class TruncateQuery : CompiledQuery
    {
        private readonly TruncateModel _model;

        public TruncateQuery(TruncateModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params)
        {
            throw new System.NotImplementedException();
        }
    }
}