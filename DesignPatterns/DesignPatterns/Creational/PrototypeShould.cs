using NUnit.Framework;
using Prototype.Abstractions.Models;
using Prototype.Models;

namespace DesignPatterns.Creational
{
    public class PrototypeShould
    {
        const string EMPLOYEE_NAME = "James Joyce";
        const string MANAGER_NAME = "Flann O'Brien";
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
            person1 = new Manager(MANAGER_NAME);
            person2 = person1.Clone(false);

            Assert.AreEqual(((Manager)person1).Name, ((Manager)person2).Name);
        }

        [Test()]
        public void CloneEmployee()
        {
            person1 = new Employee(EMPLOYEE_NAME, new Manager(MANAGER_NAME));
            person2 = person1.Clone(false);

            Assert.AreSame(((Employee)person1).Manager, ((Employee)person2).Manager);
        }

        [Test()]
        public void DeepCloneEmployee()
        {
            person1 = new Employee(EMPLOYEE_NAME, new Manager(MANAGER_NAME));
            person2 = person1.Clone(true);

            Assert.AreNotSame(((Employee)person1).Manager, ((Employee)person2).Manager);
        }
    }
}
