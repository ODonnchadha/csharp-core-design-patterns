using AbstractFactory.Interfaces.Factories;
using AbstractFactory.Interfaces.Services;
using AbstractFactory.Services;

namespace AbstractFactory.Factories
{
    public class BelgiumShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService() => new BelgiumDiscountService { };
        public IShippingCostService CreateShippingCostService() => new BelgiumShippingCostService { };
    }
}
