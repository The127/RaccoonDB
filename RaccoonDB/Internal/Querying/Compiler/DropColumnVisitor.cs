namespace RaccoonDB.Internal.Querying.Compiler
{
    public class DropColumnModel
    {
        public string ColumnName { get; set; } = null!;

        public override string ToString() =>
            $"{nameof(DropColumnModel)}:[{nameof(ColumnName)}: '{ColumnName}']";
    }
    
    public class DropColumnVisitor : RacconDbCustomVisitorBase<DropColumnModel>
    {
        private readonly DropColumnModel _model = new();

        public override DropColumnModel VisitDropColumn(RaccoonSQLParser.DropColumnContext context)
        {
            _model.ColumnName = context.columnName.Text;
            return _model;
        }
    }
}