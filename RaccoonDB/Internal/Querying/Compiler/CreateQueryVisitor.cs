using System;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class CreateQueryVisitor : RacconDbCustomVisitorBase<CompiledQuery>
    {
        public override CompiledQuery VisitCreateTable(RaccoonSQLParser.CreateTableContext context)
        {
            return new CreateTableQuery(new CreateTableVisitor().Visit(context));
        }

        public override CompiledQuery VisitCreateIndex(RaccoonSQLParser.CreateIndexContext context)
        {
            return new CreateIndexQuery(new CreateIndexVisitor().Visit(context));
        }
    }
}