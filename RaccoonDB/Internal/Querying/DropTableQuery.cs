using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class DropTableQuery : CompiledQuery
    {
        private readonly DropTableModel _model;

        public DropTableQuery(DropTableModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            var result = new ResultSet();
            raccoonDbStorageProvider.Write(writer =>
            {
                writer.DropTable(_model);
            });
            return result;
        }
    }
}