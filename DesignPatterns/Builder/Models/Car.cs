using System.Text;

namespace Builder.Models
{
    public class Car
    {
        private readonly List<string> _parts = new();
        private readonly string _type;
        public Car(string type) => _type = type;
        public void AddPart(string part) => _parts.Add(part);
        public override string ToString()
        {
            var sb = new StringBuilder { };
            _parts.ForEach(p => sb.Append($"{p} "));

            return sb.ToString().Trim();
        }
    }
}
