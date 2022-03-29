using Adapter.ObjectAdapter.Services.External;
using Adapter.ObjectAdapter.Interfaces.Adapters;
using Adapter.ObjectAdapter.Models;

namespace Adapter.ObjectAdapter.Adapters
{
    public class CityAdapter : ICityAdapter
    {
        public ExternalCityService ExternalCityService { get; private set; } = new();
        public City GetCity()
        {
            var city = ExternalCityService.GetCity();

            return new City
                (
                    $"{city.Name} - {city.Nickname}",
                    city.Inhabitants
                );
        }
    }
}
