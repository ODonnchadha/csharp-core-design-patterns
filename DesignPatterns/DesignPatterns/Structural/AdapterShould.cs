using Adapter.ObjectAdapter.Adapters;
using Adapter.ObjectAdapter.Interfaces.Adapters;
using NUnit.Framework;

namespace DesignPatterns.Structural
{
    public class AdapterShould
    {
        private ICityAdapter? adapter;

        [SetUp()]
        public void SetUp()
        {
            adapter = new CityAdapter { };
        }

        [Test()]
        public void GetObjectAdapter()
        {
            var city = adapter?.GetCity();

            Assert.AreEqual(city?.Population, 100578);
        }
    }
}
