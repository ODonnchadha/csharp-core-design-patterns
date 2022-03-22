using Creational.FactoryMethod.Abstractions.Factories;
using Creational.FactoryMethod.Abstractions.Services;
using Creational.FactoryMethod.Services;

namespace Creational.FactoryMethod.Factories
{
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _country;
        public CountryDiscountFactory(string country) => _country = country;
        public override DiscountService Create() => new CountryDiscountService(_country);
    }
}
