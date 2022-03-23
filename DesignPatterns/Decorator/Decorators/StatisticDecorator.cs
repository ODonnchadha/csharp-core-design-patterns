using Decorator.Abstractions;
using Decorator.Interfaces;

namespace Decorator.Decorators
{
    public class StatisticDecorator : MailServiceDecorator
    {
        public StatisticDecorator(IMailService service) : base(service) { }
        public override string Send(string message) => base.Send($"{message} {GetType().Name}");
    }
}
