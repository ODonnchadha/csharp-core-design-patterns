using Interpreter.Contexts;

namespace Interpreter.Abstractions.Expressions
{
    /// <summary>
    /// Abstract Expression.
    /// </summary>
    public abstract class RomanExpression
    {
        public abstract void Interpret(RomanContext context);
    }
}
