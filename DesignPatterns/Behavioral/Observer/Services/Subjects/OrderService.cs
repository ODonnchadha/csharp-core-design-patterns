using Observer.Abstractions;
using Observer.Models;

namespace Observer.Services.Subjects
{
    /// <summary>
    /// Concrete Subject.
    /// NOTE: Concrete Subjects are responsible for managing their own state.
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
