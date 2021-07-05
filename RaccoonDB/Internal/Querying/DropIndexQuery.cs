using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Querying
{
    public class DropIndexQuery : CompiledQuery
    {
        private readonly DropIndexModel _model;

        public DropIndexQuery(DropIndexModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params)
        {
            throw new System.NotImplementedException();
        }
    }
}