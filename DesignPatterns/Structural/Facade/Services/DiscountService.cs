namespace Facade.Services
{
    public class DiscountService
    {
        public double Calculate(int id) => id > 8 ? 10 : 20;
    }
}
