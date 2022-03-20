using AbstractFactory.Interfaces.Factories;
using AbstractFactory.Interfaces.Services;
using AbstractFactory.Services;

namespace AbstractFactory.Factories
{
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscountService CreateDiscountService() => new FranceDiscountService { };
        public IShippingCostService CreateShippingCostService() => new FranceShippingCostService { };
    }
}
