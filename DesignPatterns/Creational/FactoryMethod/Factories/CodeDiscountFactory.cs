using Creational.FactoryMethod.Abstractions.Factories;
using Creational.FactoryMethod.Abstractions.Services;
using Creational.FactoryMethod.Services;

namespace Creational.FactoryMethod.Factories
{
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFactory(Guid code) => _code = code;
        public override DiscountService Create() => new CodeDiscountService(_code);
    }
}
