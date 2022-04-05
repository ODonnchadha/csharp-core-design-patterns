using ChainOfResponsibility.Interfaces.Handlers;
using ChainOfResponsibility.Models;
using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility.Handlers
{
    public class DocumentApprovedByManagementHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document request)
        {
            if (request.ApprovedByManagement.Equals(false))
            {
                var t = GetType().Name;

                throw new ValidationException(
                    new ValidationResult(
                        t, new List<string>() { t }), null, null);
            }

            _successor?.Handle(request);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;

            return _successor;
        }
    }
}
