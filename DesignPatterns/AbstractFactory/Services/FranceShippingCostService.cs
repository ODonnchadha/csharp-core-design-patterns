using AbstractFactory.Interfaces.Services;

namespace AbstractFactory.Services
{
    public class FranceShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => -8M;
    }
}
