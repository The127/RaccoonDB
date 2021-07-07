using Antlr4.Runtime;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class SqlQueryCompiler
    {
        public CompiledQuery Compile(string sql)
        {
            var inputStream = new AntlrInputStream(sql);
            var speakLexer = new RaccoonSQLLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(speakLexer);
            var speakParser = new RaccoonSQLParser(commonTokenStream);
            var chatContext = speakParser.query();
            var visitor = new QueryVisitor();        
            var query = visitor.Visit(chatContext);
            return query;
        }
    }
}       