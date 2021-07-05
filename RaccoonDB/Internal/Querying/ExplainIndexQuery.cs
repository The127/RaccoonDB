using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Querying
{
    public class ExplainIndexQuery : CompiledQuery
    {
        private readonly ExplainIndexModel _model;

        public ExplainIndexQuery(ExplainIndexModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params)
        {
            throw new System.NotImplementedException();
        }
    }
}