using Visitor.Models;

namespace Visitor.Interfaces.Visitors
{
    public interface IVisitor
    {
        void VisitCustomer(Customer visitor);
        void VisitEmployee(Employee visitor);
    }
}
