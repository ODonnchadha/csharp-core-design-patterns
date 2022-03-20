using AbstractFactory.Interfaces.Services;

namespace AbstractFactory.Services
{
    internal class BelgiumShippingCostService : IShippingCostService
    {
        public decimal ShippingCosts => 40M;
    }
}
