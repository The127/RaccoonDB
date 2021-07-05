namespace RaccoonDB.Internal.Querying.Compiler
{
    public class ExplainIndexModel
    {
        public string IndexName { get; set; } = null!;
        public string TableName { get; set; } = null!;

        public override string ToString() =>
            $"{nameof(ExplainIndexModel)}[{nameof(IndexName)}: '{IndexName}', {nameof(TableName)}: '{TableName}']";
    }
    
    public class ExplainIndexVisitor : RaccoonSQLBaseVisitor<ExplainIndexModel>
    {
        private readonly ExplainIndexModel _model = new();

        public override ExplainIndexModel VisitIndex(RaccoonSQLParser.IndexContext context)
        {
            _model.IndexName = context.indexIdentifier.Text;
            _model.TableName = context.tableIdentifier.Text;
            return _model;
        }
    }
}