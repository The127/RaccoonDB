namespace RaccoonDB.Internal.Querying.Compiler
{
    public class AddColumnModel
    {
        public string TableName { get; set; } = null!;
        public TableColumnModel ColumnModel { get; set; } = null!;
    }
    
    public class AddColumnVisitor : RaccoonSQLBaseVisitor<AddColumnModel>
    {
        private readonly AddColumnModel _model = new();

        public override AddColumnModel VisitTable(RaccoonSQLParser.TableContext context)
        {
            _model.TableName = context.tableName.Text;
            return _model;
        }

        public override AddColumnModel VisitTableColumn(RaccoonSQLParser.TableColumnContext context)
        {
            _model.ColumnModel = new TableColumnVisitor().Visit(context);
            return _model;
        }
    }
}