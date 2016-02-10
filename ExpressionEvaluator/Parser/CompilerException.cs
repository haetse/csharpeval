using System;

namespace ExpressionEvaluator.Parser
{
    public class CompilerException : Exception
    {
        public CompilerException(string message)
            : base(message)
        {
        }
    }
}