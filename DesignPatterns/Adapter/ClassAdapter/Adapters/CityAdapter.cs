using Adapter.ClassAdapter.Services.External;
using Adapter.ClassAdapter.Interfaces.Adapters;
using Adapter.ClassAdapter.Models;

namespace Adapter.ClassAdapter.Adapters
{
    public class CityAdapter : ExternalCityService, ICityAdapter
    {
        public City GetCity()
        {
            var city = base.GetCity();

            return new City
                (
                    $"{city.Name} - {city.Nickname}",
                    city.Inhabitants
                );
        }
    }
}
