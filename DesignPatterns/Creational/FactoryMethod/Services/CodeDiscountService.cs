using Creational.FactoryMethod.Abstractions.Services;

namespace Creational.FactoryMethod.Services
{
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;
        public CodeDiscountService(Guid code) => _code = code;
        public override int DiscountPercentage 
        {
            get => 15;
        }
    }
}
