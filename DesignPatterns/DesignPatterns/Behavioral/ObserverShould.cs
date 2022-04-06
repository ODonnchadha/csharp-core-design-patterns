using NUnit.Framework;
using Observer.Services.Observers;
using Observer.Services.Subjects;

namespace DesignPatterns.Behavioral
{
    public class ObserverShouldShould
    {
        OrderService service = new();

        [SetUp()]
        public void SetUp()
        {
            service.Add(new TicketStockService { });
            service.Add(new TickerResellerService { });
        }

        [Test()]
        public void Observe()
        {
            Assert.AreEqual(
                service.CompleteTicketSale(1, 400), 
                "OrderService notifying 2 observers.");
        }
    }
}
