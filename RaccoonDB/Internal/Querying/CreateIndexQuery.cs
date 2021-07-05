using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class CreateIndexQuery : CompiledQuery
    {
        private readonly CreateIndexModel _model;

        public CreateIndexQuery(CreateIndexModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            var result = new ResultSet();
            raccoonDbStorageProvider.Write(writer =>
            {
                writer.CreateIndex(_model);
            });
            return result;
        }
    }
}