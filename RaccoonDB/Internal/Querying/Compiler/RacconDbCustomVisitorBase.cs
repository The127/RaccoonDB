namespace RaccoonDB.Internal.Querying.Compiler
{
    public abstract class RacconDbCustomVisitorBase<T> : RaccoonSQLBaseVisitor<T>
    {
        protected override T AggregateResult(T aggregate, T nextResult)
        {
            return aggregate ?? nextResult;
        }
    }
}