namespace RaccoonDB.Internal.Querying.Compiler
{
    public class AlterQueryVisitor : RacconDbCustomVisitorBase<CompiledQuery>
    {
        private RaccoonSQLParser.TableContext _tableContext = null!; 
        
        public override CompiledQuery VisitTable(RaccoonSQLParser.TableContext context)
        {
            _tableContext = context;
            return base.VisitTable(context);
        }

        public override CompiledQuery VisitAddColumn(RaccoonSQLParser.AddColumnContext context)
        {
            return new AddColumnQuery(new AddColumnVisitor().Visit(_tableContext));
        }

        public override CompiledQuery VisitDropColumn(RaccoonSQLParser.DropColumnContext context)
        {
            return new DropColumnQuery(new DropColumnVisitor().Visit(_tableContext));
        }

        public override CompiledQuery VisitAlterColumn(RaccoonSQLParser.AlterColumnContext context)
        {
            return new AlterColumnQuery(new AlterColumnVisitor().Visit(_tableContext));
        }
    }
}