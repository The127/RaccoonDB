using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class CreateTableQuery : CompiledQuery
    {
        private readonly CreateTableModel _model;

        public CreateTableQuery(CreateTableModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            var result = new ResultSet();
            raccoonDbStorageProvider.Write(writer =>
            {
                writer.CreateTable(_model);
            });
            return result;
        }
    }
}