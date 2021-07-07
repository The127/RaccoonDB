using RaccoonDB.Interface;
using RaccoonDB.Internal.Querying.Compiler;
using RaccoonDB.Internal.Storage;

namespace RaccoonDB.Internal.Querying
{
    public class ExplainIndexQuery : CompiledQuery
    {
        private readonly ExplainIndexModel _model;

        public ExplainIndexQuery(ExplainIndexModel model)
        {
            _model = model;
        }

        public override ResultSet Execute(object[] @params, IRaccoonDbStorageProvider raccoonDbStorageProvider)
        {
            IndexInformation indexInfo = null!;
            raccoonDbStorageProvider.Read(reader =>
            {
                indexInfo = reader.ExplainIndex(_model);
            });
            var resultSet = new ResultSet(
                "index_name",
                "unique",
                "column_names"
            );
            
            resultSet.AddRow(new ResultRow(
                indexInfo.Name,
                indexInfo.Unique,
                string.Join(", ", indexInfo.ColumnNames)
            ));
            
            return resultSet;
        }
    }
}