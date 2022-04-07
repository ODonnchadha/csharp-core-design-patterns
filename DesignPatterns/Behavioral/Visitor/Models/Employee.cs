using Visitor.Interfaces.Elements;
using Visitor.Interfaces.Visitors;

namespace Visitor.Models
{
    /// <summary>
    /// Concrete Element.
    /// </summary>
    public class Employee : IElement
    {
        public int YearsEmployed { get; private set; }
        public decimal Discount { get; set; }
        public string Name { get; private set; }
        public Employee(string name, int yearsEmployed)
        {
            Name = name;
            YearsEmployed = yearsEmployed;
        }
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}