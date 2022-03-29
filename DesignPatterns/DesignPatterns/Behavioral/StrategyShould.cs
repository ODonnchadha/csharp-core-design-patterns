using NUnit.Framework;
using Strategy.Models;
using Strategy.Services;

namespace DesignPatterns.Behavioral
{
    public class StrategyShould
    {
        private Order? order;
        [SetUp()]
        public void SetUp() { order = new Order("CUSTOMER", 40, "NAME"); }

        [TearDown()]
        public void TearDown() { order = null; }

        [Test()]
        public void XML()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            order.ExportService = new XmlExportService { };
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            order.Export();

            Assert.AreEqual(order.Description, "XmlExportService");
        }

        [Test()]
        public void JSON()
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            order.ExportService = new JsonExportService { };
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            order.Export();

            Assert.AreEqual(order.Description, "JsonExportService");
        }
    }
}
