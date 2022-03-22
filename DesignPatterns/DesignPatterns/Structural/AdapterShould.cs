using NUnit.Framework;

namespace DesignPatterns.Structural
{
    public class AdapterShould
    {
        [Test()]
        public void GetObjectAdapter()
        {
            Adapter.ObjectAdapter.Interfaces.Adapters.ICityAdapter adapter 
                = new Adapter.ObjectAdapter.Adapters.CityAdapter { };

            var city = adapter?.GetCity();

            Assert.AreEqual(city?.Population, 100578);
        }

        [Test()]
        public void GetClassAdapter()
        {
            Adapter.ClassAdapter.Adapters.CityAdapter adapter 
                = new Adapter.ClassAdapter.Adapters.CityAdapter { };
               
            var city = adapter?.GetCity();

            Assert.AreEqual(city?.Population, 100578);
        }
    }
}
