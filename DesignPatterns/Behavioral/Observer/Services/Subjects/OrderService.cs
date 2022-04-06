using Observer.Abstractions;
using Observer.Models;

namespace Observer.Services.Subjects
{
    /// <summary>
    /// Concrete Subject.
    /// </summary>
    public class OrderService : TickerChangeNotifier
    {
        public string CompleteTicketSale(int id, int amount)
        {
            var i = Notify(new TicketChange(id, amount));

            return $"{nameof(OrderService)} notifying {i} observers.";
        }
    }
}
