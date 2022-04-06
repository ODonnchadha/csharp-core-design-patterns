using Visitor.Interfaces.Visitors;
using Visitor.Models;

namespace Visitor.Visitors
{
    /// <summary>
    /// Concrete Visitor.
    /// </summary>
    public class DiscountVisitor : IVisitor
    {
        public decimal TotalDiscountProvided { get; set; }
        public void VisitCustomer(Customer visitor)
        {
            var discount = visitor.OrderAmount / 10;
            visitor.Discount = discount;

            TotalDiscountProvided += discount;
        }

        public void VisitEmployee(Employee visitor)
        {
            var discount = visitor.YearsEmployed < 10 ? 100 : 200;
            visitor.Discount = discount;

            TotalDiscountProvided += discount;
        }
    }
}
