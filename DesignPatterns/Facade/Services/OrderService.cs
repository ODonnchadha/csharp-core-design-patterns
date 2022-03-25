namespace Facade.Services
{
    public class OrderService
    {
        public bool HasEnoughOrders(int id) => id > 5;
    }
}
