using Newtonsoft.Json;
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

        public override Person Clone(bool isDeepCopy = false)
        {
            if (isDeepCopy)
            {
                var json = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Employee>(json);
            }

            return (Person)MemberwiseClone();
        }
    }
}
