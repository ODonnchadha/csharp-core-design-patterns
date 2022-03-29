using Decorator.Interfaces;

namespace Decorator.Services
{    
    /// <summary>
    /// Concrete component.
    /// </summary>
    public class OnPremiseMailService : IMailService
    {
        public string Send(string message) => $"{message} {GetType().Name}";
    }
}
