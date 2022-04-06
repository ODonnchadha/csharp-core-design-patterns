using Observer.Interfaces.Listeners;
using Observer.Models;

namespace Observer.Services.Observers
{
    public class TickerResellerService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange change) { }
    }
}
