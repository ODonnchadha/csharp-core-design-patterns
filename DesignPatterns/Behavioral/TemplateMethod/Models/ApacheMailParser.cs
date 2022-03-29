using TemplateMethod.Abstractions;

namespace TemplateMethod.Models
{
    public class ApacheMailParser : MailParser
    {
        public override string FindServer() => $"{GetType().Name}";
        public override void AuthenticateServer() { }
    }
}