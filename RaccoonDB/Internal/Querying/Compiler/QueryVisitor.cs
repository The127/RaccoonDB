using System;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class QueryVisitor : RaccoonSQLBaseVisitor<CompiledQuery>
    {
        public override CompiledQuery VisitCreateQuery(RaccoonSQLParser.CreateQueryContext context)
        {
            return new CreateQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitDropQuery(RaccoonSQLParser.DropQueryContext context)
        {
            return new DropQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitAlterQuery(RaccoonSQLParser.AlterQueryContext context)
        {
            return new AlterQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitExplainQuery(RaccoonSQLParser.ExplainQueryContext context)
        {
            return new ExplainQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitTruncateQuery(RaccoonSQLParser.TruncateQueryContext context)
        {
            return new TruncateQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitSelectQuery(RaccoonSQLParser.SelectQueryContext context)
        {
            return new SelectQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitUpdateQuery(RaccoonSQLParser.UpdateQueryContext context)
        {
            return new UpdateQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitDeleteQuery(RaccoonSQLParser.DeleteQueryContext context)
        {
            return new DeleteQueryVisitor().Visit(context);
        }

        public override CompiledQuery VisitInsertQuery(RaccoonSQLParser.InsertQueryContext context)
        {
            return new InsertQueryVisitor().Visit(context);
        }
    }
}