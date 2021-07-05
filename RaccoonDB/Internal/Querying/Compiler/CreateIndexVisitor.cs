using System.Collections.Generic;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class CreateIndexModel
    {
        public bool Unique { get; set; }
        public string IndexName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public List<string> Columns { get; } = new();
    }
    
    public class CreateIndexVisitor : RacconDbCustomVisitorBase<CreateIndexModel>
    {
        private readonly CreateIndexModel _model = new();

        public override CreateIndexModel VisitIndex(RaccoonSQLParser.IndexContext context)
        {
            _model.IndexName = context.indexIdentifier.Text;
            _model.TableName = context.tableIdentifier.Text;
            return _model;
        }

        public override CreateIndexModel VisitIndexColumn(RaccoonSQLParser.IndexColumnContext context)
        {
            if (_model.Columns.Contains(context.columnName.Text))
                throw new SqlCompilationException($"duplicate column name for index {_model.IndexName} on table {_model.TableName}", context);
            _model.Columns.Add(context.columnName.Text);
            return _model;
        }

        public override CreateIndexModel VisitUniqueConstraint(RaccoonSQLParser.UniqueConstraintContext context)
        {
            _model.Unique = true;
            return _model;
        }
    }
}