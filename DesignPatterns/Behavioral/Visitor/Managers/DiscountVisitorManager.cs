using Visitor.Interfaces.Visitors;
using Visitor.Models;

namespace Visitor.Managers
{
    public class DiscountVisitorManager
    {
        public List<Employee> Employees { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();

        public void Accept(IVisitor visitor)
        {
            Employees.ForEach(e => e.Accept(visitor));
            Customers.ForEach(e => e.Accept(visitor));
        }
    }
}
