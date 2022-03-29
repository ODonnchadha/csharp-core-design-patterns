using Facade.Services;

namespace Facade.Facades
{
    public class DiscountFacade
    {
        private readonly CalendarService _calendar = new();
        private readonly DiscountService _discount = new();
        private readonly OrderService _order = new();
        public double CalculateDiscountPercentage(int id) => 
            !_order.HasEnoughOrders(id) ? 0 :_discount.Calculate(id) * _calendar.Week();
    }
}
