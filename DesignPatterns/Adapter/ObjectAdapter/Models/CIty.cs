namespace Adapter.ObjectAdapter.Models
{
    public class City
    {
        public string FullName { get; private set; }
        public long Population { get; private set; }

        public City(string fullName, long population)
        {
            FullName = fullName;
            Population = population;
        }
    }
}
