using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;

namespace RaccoonDB.Internal.Querying
{
    public class CreateIndexQuery : CompiledQuery
    {
        private readonly CreateIndexModel _model;

        public CreateIndexQuery(CreateIndexModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params)
        {
            throw new System.NotImplementedException();
        }
    }
}