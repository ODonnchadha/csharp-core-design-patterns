using Observer.Models;

namespace Observer.Interfaces.Listeners
{
    /// <summary>
    /// Observer.
    /// </summary>
    public interface ITicketChangeListener
    {
        void ReceiveTicketChangeNotification(TicketChange change);
    }
}
