using Newtonsoft.Json;
using Prototype.Abstractions.Models;

namespace Prototype.Models
{
    public class Manager : Person
    {
        public override string Name { get; set; }
        public Manager(string name) => Name = name;

        public override Person Clone(bool isDeepCopy = false)
        {
            if (isDeepCopy)
            {
                var json = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Manager>(json);
            }

            return (Person)MemberwiseClone();
        }
    }
}
