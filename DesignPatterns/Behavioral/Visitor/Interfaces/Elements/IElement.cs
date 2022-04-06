using Visitor.Interfaces.Visitors;

namespace Visitor.Interfaces.Elements
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
