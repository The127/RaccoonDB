namespace RaccoonDB.Internal.Querying.Compiler
{
    public class TruncateModel
    {
        public string TableName { get; set; } = null!;

        public override string ToString() =>
            $"{nameof(TruncateModel)}[{nameof(TableName)}: '{TableName}']";
    }
    
    public class TruncateVisitor : RaccoonSQLBaseVisitor<TruncateModel>
    {
        private readonly TruncateModel _model = new();

        public override TruncateModel VisitTable(RaccoonSQLParser.TableContext context)
        {
            _model.TableName = context.tableName.Text;
            return _model;
        }
    }
}