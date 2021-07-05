namespace RaccoonDB.Internal.Querying.Compiler
{
    public class TruncateQueryVisitor : RacconDbCustomVisitorBase<CompiledQuery>
    {
        public override CompiledQuery VisitTruncateQuery(RaccoonSQLParser.TruncateQueryContext context)
        {
            return new TruncateQuery(new TruncateVisitor().Visit(context));
        }
    }
}