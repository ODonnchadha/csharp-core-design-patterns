using NUnit.Framework;
using Prototype.Abstractions.Models;
using Prototype.Models;

namespace DesignPatterns.Creational
{
    public class PrototypeShould
    {
        Person? person1;
        Person? person2;

        [TearDown()]
        public void TearDown()
        {
            person1 = null;
            person2 = null;
        }

        [Test()]
        public void CloneManager()
        {
            person1 = new Manager("Flann O'Brien");
            person2 = person1.Clone();

            Assert.AreEqual(((Manager)person1).Name, ((Manager)person2).Name);
        }

        [Test()]
        public void CloneEmployee()
        {
            person1 = new Employee("Patrick McCabe", new Manager("Flann O'Brien"));
            person2 = person1.Clone();

            Assert.AreSame(((Employee)person1).Manager, ((Employee)person2).Manager);
        }
    }
}
