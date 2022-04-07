using Interpreter.Abstractions.Expressions;
using Interpreter.Contexts;
using Interpreter.Expressions;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral
{
    public class InterpreterShould
    {
        private List<RomanExpression> expressions = new();
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private RomanContext context;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [SetUp()]
        public void SetUp()
        {
            expressions.Add(new RomanTenExpression { });
            expressions.Add(new RomanOneExpression { });
        }

        [TearDown()]
        public void TearDown() { }

        [Test()]
        public void Interpret()
        {
            context = new RomanContext(53);
            expressions.ForEach(e => e.Interpret(context));
            Assert.AreEqual(context.Output, "LIII");

            context = new RomanContext(5);
            expressions.ForEach(e => e.Interpret(context));
            Assert.AreEqual(context.Output, "V");

            context = new RomanContext(89);
            expressions.ForEach(e => e.Interpret(context));
            Assert.AreEqual(context.Output, "LXXXIX");
        }
    }
}
