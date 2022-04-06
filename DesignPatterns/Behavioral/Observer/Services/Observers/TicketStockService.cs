using Observer.Interfaces.Listeners;
using Observer.Models;

namespace Observer.Services.Observers
{
    /// <summary>
    /// Concrete Observer.
    /// </summary>
    public class TicketStockService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange change) { }
    }
}