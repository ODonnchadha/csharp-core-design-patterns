using NUnit.Framework;
using TemplateMethod.Models;

namespace DesignPatterns.Behavioral
{
    public class TemplateMethodShould
    {
        [SetUp()]
        public void SetUp() { }

        [TearDown()]
        public void TearDown() { }

        [Test()]
        public void ExecuteApache()
        {
            ApacheMailParser mail = new ApacheMailParser { };
            string identifier = "ApacheMailParser";

            var result = mail.Execute(identifier);

            Assert.AreEqual(result, "Id: ApacheMailParser ApacheMailParser");
        }

        [Test()]
        public void ExecuteExchange()
        {
            ExchangeMailParser mail = new ExchangeMailParser { };
            string identifier = "ExchangeMailParser";

            var result = mail.Execute(identifier);

            Assert.AreEqual(result, "Id: ExchangeMailParser MailParser");
        }
    }
}
