namespace Creational.Singleton.Models
{
    public class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        public static Logger Instance { get { return _instance.Value; } }
        protected Logger() { }
        public void Log(string message) { }
    }
}
