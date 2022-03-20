using Creational.FactoryMethod.Abstractions.Services;

namespace Creational.FactoryMethod.Services
{
    public class CountryDiscountService : DiscountService
    {
        private readonly string _country;
        public CountryDiscountService(string country) => _country = country;
        public override int DiscountPercentage
        {
            get
            {
                switch(_country)
                {
                    case "BE":
                        return 15;
                    default:
                        return 10;
                }
            }
        }
    }
}
