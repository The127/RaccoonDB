namespace RaccoonDB.Internal.Querying.Compiler
{
    public class AlterColumnModel
    {
        public TableColumnModel ColumnModel { get; set; } = null!;
    }
    
    public class AlterColumnVisitor : RaccoonSQLBaseVisitor<AlterColumnModel>
    {
        private readonly AlterColumnModel _model = new();

        public override AlterColumnModel VisitTableColumn(RaccoonSQLParser.TableColumnContext context)
        {
            _model.ColumnModel = new TableColumnVisitor().Visit(context);
            return _model;
        }
    }
}