using Visitor.Interfaces.Elements;

namespace Visitor.Interfaces.Visitors
{
    public interface IVisitor
    {
        //void VisitCustomer(Customer visitor);
        //void VisitEmployee(Employee visitor);
        void Visit(IElement element);
    }
}
