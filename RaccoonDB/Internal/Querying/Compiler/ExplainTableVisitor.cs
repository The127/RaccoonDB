namespace RaccoonDB.Internal.Querying.Compiler
{
    public class ExplainTableModel
    {
        public string TableName { get; set; } = null!;
    }
    
    public class ExplainTableVisitor : RaccoonSQLBaseVisitor<ExplainTableModel>
    {
        private readonly ExplainTableModel _model = new();

        public override ExplainTableModel VisitTable(RaccoonSQLParser.TableContext context)
        {
            _model.TableName = context.tableName.Text;
            return _model;
        }
    }
}