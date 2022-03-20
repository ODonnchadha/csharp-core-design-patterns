using Prototype.Abstractions.Models;

namespace Prototype.Models
{
    public class Employee : Person
    {
        public Manager? Manager { get; set; }
        public override string Name { get; set; }
        public Employee(string name, Manager? manager)
        {
            Name = name;
            Manager = manager;
        }
        public override Person Clone() => (Person)MemberwiseClone();
    }
}
