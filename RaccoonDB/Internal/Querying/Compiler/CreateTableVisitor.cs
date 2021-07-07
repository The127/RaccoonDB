using System.Collections.Generic;
using System.Linq;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class CreateTableModel
    {
        public bool IfNotExists { get; set; }
        public string TableName { get; set; } = null!;
        public List<TableColumnModel> Columns { get; } = new();

        public override string ToString() =>
            $"{nameof(CreateTableModel)}[{nameof(TableName)}: '{TableName}', {nameof(Columns)}: '{string.Join(", " , Columns.Select(x => x.ToString()))}']";
    }
    
    public class CreateTableVisitor : RacconDbCustomVisitorBase<CreateTableModel>
    {
        private readonly CreateTableModel _model = new();

        public override CreateTableModel VisitTable(RaccoonSQLParser.TableContext context)
        {
            _model.TableName = context.tableName.Text;
            VisitChildren(context);
            return _model;
        }

        public override CreateTableModel VisitTableColumn(RaccoonSQLParser.TableColumnContext context)
        {
            _model.Columns.Add(new TableColumnVisitor().Visit(context));
            return _model;
        }

        public override CreateTableModel VisitIfNotExists(RaccoonSQLParser.IfNotExistsContext context)
        {
            _model.IfNotExists = true;
            return _model;
        }
    }
}