using Visitor.Interfaces.Elements;
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

        public void Visit(IElement element)
        {
            if (element is Employee)
            {
                Visit((Employee)element);
            }

            if (element is Customer)
            {
                Visit((Customer)element);
            }
        }

        private void Visit(Customer visitor)
        {
            var discount = visitor.OrderAmount / 10;
            visitor.Discount = discount;

            TotalDiscountProvided += discount;
        }

        private void Visit(Employee visitor)
        {
            var discount = visitor.YearsEmployed < 10 ? 100 : 200;
            visitor.Discount = discount;

            TotalDiscountProvided += discount;
        }
    }
}
