namespace RaccoonDB.Internal.Querying.Compiler
{
    public enum ExplainTableMode
    {
        Columns,
        Indices,
    }
    
    public class ExplainTableModel
    {
        public ExplainTableMode ExplainTableMode { get; set; } = ExplainTableMode.Columns;
        public string TableName { get; set; } = null!;

        public override string ToString() =>
            $"{nameof(ExplainTableModel)}[{nameof(TableName)}: '{TableName}']";
    }
    
    public class ExplainTableVisitor : RacconDbCustomVisitorBase<ExplainTableModel>
    {
        private readonly ExplainTableModel _model = new();

        public override ExplainTableModel VisitTable(RaccoonSQLParser.TableContext context)
        {
            _model.TableName = context.tableName.Text;
            return _model;
        }

        public override ExplainTableModel VisitExplainIndicesOnTable(RaccoonSQLParser.ExplainIndicesOnTableContext context)
        {
            _model.ExplainTableMode = ExplainTableMode.Indices;
            VisitChildren(context);
            return _model;
        }
    }
}