namespace RaccoonDB.Internal.Querying.Compiler
{
    public class DropQueryVisitor : RaccoonSQLBaseVisitor<CompiledQuery>
    {
        public override CompiledQuery VisitIndex(RaccoonSQLParser.IndexContext context)
        {
            return new DropIndexQuery(new DropIndexVisitor().Visit(context));
        }

        public override CompiledQuery VisitTable(RaccoonSQLParser.TableContext context)
        {
            return new DropTableQuery(new DropTableVisitor().Visit(context));
        }
    }
}