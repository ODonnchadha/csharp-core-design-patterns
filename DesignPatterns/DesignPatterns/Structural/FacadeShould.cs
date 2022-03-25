using Facade.Facades;
using NUnit.Framework;

namespace DesignPatterns.Structural
{
    public class FacadeShould
    {
        private DiscountFacade? f;

        [SetUp()]
        public void SetUp() => f = new DiscountFacade { };

        [TearDown()]
        public void TearDown() => f = null;

            [Test()]
        public void Calculate()
        {
            Assert.AreEqual(f?.CalculateDiscountPercentage(1), 0);
            Assert.AreEqual(f?.CalculateDiscountPercentage(100), 12);
        }
    }
}
