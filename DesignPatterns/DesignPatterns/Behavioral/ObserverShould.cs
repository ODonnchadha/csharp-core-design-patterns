using NUnit.Framework;
using Observer.Services.Observers;
using Observer.Services.Subjects;

namespace DesignPatterns.Behavioral
{
    public class ObserverShouldShould
    {
        OrderService service = new();

        [SetUp()]
        public void SetUp() => service.Add(new TicketStockService { });

        [Test()]
        public void Observe()
        {
            TickerResellerService resale = new TickerResellerService { };
            service.Add(resale);

            Assert.AreEqual(
                service.CompleteTicketSale(1, 400), 
                "OrderService notifying 2 observers.");

            service.Remove(resale);

            Assert.AreEqual(
                service.CompleteTicketSale(1, 444),
                "OrderService notifying 1 observers.");
        }
    }
}
