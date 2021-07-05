using System;
using System.Drawing;
using Antlr4.Runtime;

namespace RaccoonDB.Internal.Querying.Compiler
{
    public class SqlCompilationException : Exception
    {
        public SqlCompilationException(string message, ParserRuleContext context)
            : base($"Parse error near {context.Start.Line}:{context.Start.Column}: {message}")
        {
        }
    }
}