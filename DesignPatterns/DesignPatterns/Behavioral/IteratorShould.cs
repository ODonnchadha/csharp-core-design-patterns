using Iterator.Collections;
using Iterator.Models;
using NUnit.Framework;

namespace DesignPatterns.Behavioral
{
    public class IteratorShould
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        PeopleCollection people;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [SetUp()]
        public void SetUp()
        {
            people = new();
            people.Add(new Person("Danny", string.Empty));
            people.Add(new Person("Daniel", string.Empty));
            people.Add(new Person("Dan", string.Empty));
        }

        [TearDown()]
        public void TearDown()
        {
        }

        [Test()]
        public void Interate()
        {
            var iterator = people.CreateIterator();

            Assert.AreEqual(iterator.First().Name, "Dan");
            Assert.AreEqual(iterator.Next().Name, "Daniel");
            Assert.AreEqual(iterator.CurrentItem.Name, "Daniel");
            Assert.AreEqual(iterator.Next().Name, "Danny");

            var p = iterator.Next();
            Assert.AreEqual(iterator.IsDone, true);
        }
    }
}
