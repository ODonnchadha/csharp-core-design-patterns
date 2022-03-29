using Strategy.Interfaces.Services;
using Strategy.Models;

namespace Strategy.Services
{
    public class XmlExportService : IExportService
    {
        public void Export(Order order) => order.Description = $"{GetType().Name}";
    }
}
