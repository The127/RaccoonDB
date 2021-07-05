using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class TruncateQuery : CompiledQuery
    {
        private readonly TruncateModel _model;

        public TruncateQuery(TruncateModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            var result = new ResultSet();
            raccoonDbStorageProvider.Write(writer =>
            {
                writer.TruncateTable(_model);
            });
            return result;
        }
    }
}