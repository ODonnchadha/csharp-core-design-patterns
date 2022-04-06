using NUnit.Framework;
using Visitor.Managers;
using Visitor.Models;
using Visitor.Visitors;

namespace DesignPatterns.Behavioral
{
    public class VisitorShould
    {
        private DiscountVisitorManager manager = new();

        [SetUp()]
        public void SetUp()
        {
            manager.Employees.Add(new Employee("Flann O'Brien", 9));
            manager.Employees.Add(new Employee("James Jpyce", 10));
            manager.Customers.Add(new Customer("Robert McLiam Wilson", (decimal)23.55));
            manager.Customers.Add(new Customer("Patrick McCabe", (decimal)0.04));
        }

        [TearDown()]
        public void TearDown() { }

        [Test()]
        public void Vist()
        {
            DiscountVisitor visitor = new();
            manager.Accept(visitor);

            Assert.AreEqual(visitor.TotalDiscountProvided, (decimal)302.359);
        }
    }
}
