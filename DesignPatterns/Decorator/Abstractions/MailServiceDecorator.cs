using Decorator.Interfaces;

namespace Decorator.Abstractions
{
    /// <summary>
    /// Decorator.
    /// </summary>
    public abstract class MailServiceDecorator : IMailService
    {
        private readonly IMailService _service;
        public MailServiceDecorator(IMailService service) => _service = service;
        public virtual string Send(string message) => _service.Send(message);
    }
}
