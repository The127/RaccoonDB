using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class ExplainTableQuery : CompiledQuery
    {
        private readonly ExplainTableModel _model;

        public ExplainTableQuery(ExplainTableModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            throw new System.NotImplementedException();
        }
    }
}