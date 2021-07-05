using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class AlterColumnQuery : CompiledQuery
    {
        private readonly AlterColumnModel _model;

        public AlterColumnQuery(AlterColumnModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            var result = new ResultSet();
            raccoonDbStorageProvider.Write(writer =>
            {
                writer.AlterColumn(_model);
            });
            return result;
        }
    }
}