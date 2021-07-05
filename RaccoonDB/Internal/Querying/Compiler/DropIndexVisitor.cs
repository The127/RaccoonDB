namespace RaccoonDB.Internal.Querying.Compiler
{
    public class DropIndexModel
    {
        public string IndexName { get; set; } = null!;
        public string TableName { get; set; } = null!;
    }
    
    public class DropIndexVisitor : RaccoonSQLBaseVisitor<DropIndexModel>
    {
        private readonly DropIndexModel _model = new();

        public override DropIndexModel VisitIndex(RaccoonSQLParser.IndexContext context)
        {
            _model.IndexName = context.indexIdentifier.Text;
            _model.TableName = context.tableIdentifier.Text;
            return _model;
        }
    }
}