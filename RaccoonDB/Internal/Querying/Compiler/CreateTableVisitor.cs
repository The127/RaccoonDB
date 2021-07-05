using System.Collections.Generic;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class CreateTableModel
    {
        public string TableName { get; set; } = null!;
        public List<TableColumnModel> Columns { get; } = new();
    }
    
    public class CreateTableVisitor : RaccoonSQLBaseVisitor<CreateTableModel>
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
    }
}