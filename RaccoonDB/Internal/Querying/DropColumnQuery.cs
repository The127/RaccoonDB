using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class DropColumnQuery : CompiledQuery
    {
        private readonly DropColumnModel _model;

        public DropColumnQuery(DropColumnModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            var result = new ResultSet();
            raccoonDbStorageProvider.Write(writer =>
            {
                writer.DropColumn(_model);
            });
            return result;
        }
    }
}