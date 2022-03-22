using Creational.FactoryMethod.Abstractions.Services;

namespace Creational.FactoryMethod.Abstractions.Factories
{
    public abstract class DiscountFactory
    {
        public abstract DiscountService Create();
    }
}
