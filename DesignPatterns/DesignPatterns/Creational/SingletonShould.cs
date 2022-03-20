using NUnit.Framework;
using Creational.Singleton.Models;

namespace DesignPatterns.Creational
{
    public class SingletonShould
    {
        private Logger instance1 = Logger.Instance;
        private Logger instance2 = Logger.Instance;

        [Test()]
        public void Instantiate()
        {
            Assert.AreEqual(instance1, instance2);
            Assert.AreEqual(instance1, Logger.Instance);
            Assert.AreEqual(instance2, Logger.Instance);
        }
    }
}