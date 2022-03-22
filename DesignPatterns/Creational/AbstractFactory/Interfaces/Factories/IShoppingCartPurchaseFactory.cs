using AbstractFactory.Interfaces.Services;

namespace AbstractFactory.Interfaces.Factories
{
    public interface IShoppingCartPurchaseFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostService CreateShippingCostService();
    }
}
