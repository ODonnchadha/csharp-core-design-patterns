using AbstractFactory.Interfaces.Services;

namespace AbstractFactory.Services
{
    public class FranceDiscountService : IDiscountService
    {
        public int DiscountPercentage => 4;
    }
}
