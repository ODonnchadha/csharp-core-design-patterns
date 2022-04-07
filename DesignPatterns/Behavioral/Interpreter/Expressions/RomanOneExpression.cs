using Interpreter.Abstractions.Expressions;
using Interpreter.Contexts;

namespace Interpreter.Expressions
{
    /// <summary>
    /// Terminal Expression:
    /// 
    /// Roman:
    /// 9 = IX
    /// 8 = VIII
    /// 7 = VII
    /// 6 = VI
    /// 5 = V
    /// 4 = IV
    /// 3 = III
    /// 2 = II
    /// 1 = I
    /// 
    /// Simplified:
    /// 9 = IX
    /// 5 = V
    /// 4 = IV
    /// 1 = I
    /// </summary>
    public class RomanOneExpression : RomanExpression
    {
        public override void Interpret(RomanContext context)
        {
            while ((context.Input - 9) >= 0)
            {
                context.Output += "IX";
                context.Input -= 9;
            }
            while ((context.Input - 5) >= 0)
            {
                context.Output += "V";
                context.Input -= 5;
            }
            while ((context.Input - 4) >= 0)
            {
                context.Output += "IV";
                context.Input -= 4;
            }
            while ((context.Input - 1) >= 0)
            {
                context.Output += "I";
                context.Input -= 1;
            }
        }
    }
}
