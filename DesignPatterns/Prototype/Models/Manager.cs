using Prototype.Abstractions.Models;

namespace Prototype.Models
{
    public class Manager : Person
    {
        public override string Name { get; set; }
        public Manager(string name) => Name = name;
        public override Person Clone() => (Person)MemberwiseClone();
    }
}
