using Visitor.Interfaces.Elements;
using Visitor.Interfaces.Visitors;

namespace Visitor.Models
{
    /// <summary>
    /// Concrete Element.
    /// </summary>
    public class Customer : IElement
    {
        public decimal OrderAmount { get; private set; }
        public decimal Discount { get; set; }
        public string Name { get; private set; }
        public Customer(string name, decimal orderAmount)
        {
            Name = name;
            OrderAmount = orderAmount;
        }
        public void Accept(IVisitor visitor) => visitor.VisitCustomer(this);
    }
}
