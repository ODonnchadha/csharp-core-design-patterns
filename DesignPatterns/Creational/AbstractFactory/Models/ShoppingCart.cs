using AbstractFactory.Interfaces.Factories;
using AbstractFactory.Interfaces.Services;

namespace AbstractFactory.Models
{
    public class ShoppingCart
    {
        private readonly IDiscountService _discount;
        private readonly IShippingCostService _shipping;

        private int _order;

        public ShoppingCart(IShoppingCartPurchaseFactory factory)
        {
            _discount = factory.CreateDiscountService();
            _shipping = factory.CreateShippingCostService();

            _order = 1000;
        }

        public decimal CalculateCost()
        {
            var discount = _order / (100 * _discount.DiscountPercentage);
            var shipping = _shipping.ShippingCosts;

            return discount + shipping;
        }
    }
}
