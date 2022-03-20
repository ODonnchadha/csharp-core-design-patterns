using AbstractFactory.Interfaces.Services;

namespace AbstractFactory.Services
{
    public class BelgiumDiscountService : IDiscountService
    {
        public int DiscountPercentage => 40;
    }
}
