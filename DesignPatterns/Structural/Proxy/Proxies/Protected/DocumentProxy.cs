using Proxy.Interfaces;

namespace Proxy.Proxies.Protected
{
    public class DocumentProxy : IDocument
    {
        private Virtual.DocumentProxy _proxy;
        private string _role;
        public DocumentProxy(string fileName, string role)
        {
            _role = role;
            _proxy = new Virtual.DocumentProxy(fileName);
        }
        public string DisplayDocument()
        {
            if (_role != "Admin")
            {
                throw new UnauthorizedAccessException();
            }

            return _proxy.DisplayDocument();
        }
    }
}
