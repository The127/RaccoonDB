namespace RaccoonDB.Internal.Querying.Compiler
{
    public class ExplainQueryVisitor : RacconDbCustomVisitorBase<CompiledQuery>
    {
        public override CompiledQuery VisitTable(RaccoonSQLParser.TableContext context)
        {
            return new ExplainTableQuery(new ExplainTableVisitor().Visit(context));
        }

        public override CompiledQuery VisitIndex(RaccoonSQLParser.IndexContext context)
        {
            return new ExplainIndexQuery(new ExplainIndexVisitor().Visit(context));
        }
    }
}