using Decorator.Interfaces;

namespace Decorator.Services
{
    /// <summary>
    /// Concrete component.
    /// </summary>
    public class CloudMailService : IMailService
    {
        public string Send(string message) => $"{message} {GetType().Name}";
    }
}
