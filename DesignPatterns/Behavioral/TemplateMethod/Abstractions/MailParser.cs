namespace TemplateMethod.Abstractions
{
    public abstract class MailParser
    {
        public virtual string FindServer() => $"MailParser";
        public abstract void AuthenticateServer();
        public string ParseBody(string identifier) => $"Id: {identifier}";
        public string Execute(string identifier)
        {
            var str = FindServer();
            AuthenticateServer();

            return $"{ParseBody(identifier)} {str}";
        }
    }
}
