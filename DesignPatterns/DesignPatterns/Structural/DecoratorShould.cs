using Decorator.Decorators;
using Decorator.Interfaces;
using Decorator.Services;
using NUnit.Framework;

namespace DesignPatterns.Structural
{
    public class DecoratorShould
    {
        private IMailService? service;
        private IMailService? decorator;

        [SetUp()]
        public void SetUp() { }

        [TearDown()]
        public void TearDown()
        {
            service = null;
            decorator = null;
        }

        [Test()]
        public void SendCloud()
        {
            service = new CloudMailService { };
            decorator = new StatisticDecorator(service);

            var msg = decorator.Send("HelloWorld");

            Assert.AreEqual(msg, "HelloWorld StatisticDecorator CloudMailService");
        }

        [Test()]
        public void SendOnPremise()
        {
            service = new OnPremiseMailService { };
            decorator = new DatabaseDecorator(service);

            var msg = decorator.Send("HelloWorld");

            Assert.AreEqual(msg, "HelloWorld DatabaseDecorator OnPremiseMailService");
        }
    }
}
