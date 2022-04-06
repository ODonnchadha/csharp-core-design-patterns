using Observer.Interfaces.Listeners;
using Observer.Models;

namespace Observer.Abstractions
{
    /// <summary>
    /// Subject.
    /// </summary>
    public abstract class TickerChangeNotifier
    {
        private List<ITicketChangeListener> _observers = new();
        public void Add(ITicketChangeListener listener) => 
            _observers.Add(listener);

        public void Remove(ITicketChangeListener listener) =>
            _observers.Remove(listener);

        public int Notify(TicketChange change)
        {
            _observers.ForEach(o =>
            {
                o.ReceiveTicketChangeNotification(change);
            });

            return _observers.Count;
        }
    }
}
