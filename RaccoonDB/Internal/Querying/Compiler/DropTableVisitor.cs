namespace RaccoonDB.Internal.Querying.Compiler
{
    public class DropTableModel
    {
        public bool IfExists { get; set; }
        public string TableName { get; set; } = null!;

        public override string ToString() =>
            $"{nameof(DropTableModel)}[{nameof(TableName)}: '{TableName}']";
    }
    
    public class DropTableVisitor : RacconDbCustomVisitorBase<DropTableModel>
    {
        private readonly DropTableModel _model = new();
        
        public override DropTableModel VisitTable(RaccoonSQLParser.TableContext context)
        {
            _model.TableName = context.tableName.Text;
            return _model;
        }

        public override DropTableModel VisitIfExists(RaccoonSQLParser.IfExistsContext context)
        {
            _model.IfExists = true;
            return _model;
        }
    }
}