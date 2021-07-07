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
            TableInformation information = null!;
            
            raccoonDbStorageProvider.Read(reader =>
            {
                information = reader.ExplainTable(_model);
            });

            ResultSet result;
            if (_model.ExplainTableMode == ExplainTableMode.Columns)
            {
                result = new ResultSet(
                    "column_name",
                    "column_type",
                    "unique",
                    "not_null", 
                    "auto_value",
                    "primary_key",
                    "foreign_key",
                    "foreign_key_table",
                    "foreign_key_column"
                );
                foreach (var columnInformation in information.Columns)
                {
                    result.AddRow(new ResultRow(
                        columnInformation.Name,
                        columnInformation.TypeName,
                        columnInformation.Unique,
                        columnInformation.NotNull,
                        columnInformation.Auto,
                        columnInformation.PrimaryKey,
                        columnInformation.ForeignKey,
                        columnInformation.ForeignTable,
                        columnInformation.ForeignColumn
                    ));
                }
            }
            else
            {
                result = new ResultSet(
                    "index_name",
                    "unique",
                    "column_names"
                );
                foreach (var indexInformation in information.Indexes)
                {
                    result.AddRow(new ResultRow(
                        indexInformation.Name,
                        indexInformation.Unique,
                        string.Join(", ", indexInformation.ColumnNames)
                    ));
                }
            }
            return result;
        }
    }
}