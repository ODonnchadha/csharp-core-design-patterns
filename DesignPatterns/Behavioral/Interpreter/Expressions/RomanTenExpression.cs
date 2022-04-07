using Interpreter.Abstractions.Expressions;
using Interpreter.Contexts;

namespace Interpreter.Expressions
{
    /// <summary>
    /// Terminal Expression:
    /// 
    /// Roman:
    /// 90 = XC
    /// 80 = LIII
    /// 70 = LII
    /// 60 = LI
    /// 50 = L
    /// 40 = XL
    /// 30 = XXX
    /// 20 = XX
    /// 10 = IX
    /// 
    /// Simplified:
    /// 90 = XC
    /// 50 = L
    /// 40 = XL
    /// 10 = X
    /// </summary>
    public class RomanTenExpression : RomanExpression
    {
        public override void Interpret(RomanContext context)
        {
            while ((context.Input - 90) >= 0)
            {
                context.Output += "XC";
                context.Input -= 90;
            }
            while ((context.Input - 50) >= 0)
            {
                context.Output += "L";
                context.Input -= 50;
            }
            while ((context.Input - 40) >= 0)
            {
                context.Output += "XL";
                context.Input -= 40;
            }
            while ((context.Input - 10) >= 0)
            {
                context.Output += "X";
                context.Input -= 10;
            }
        }
    }
}
