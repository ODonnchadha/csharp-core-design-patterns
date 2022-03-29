using Adapter.ObjectAdapter.Models.External;

namespace Adapter.ObjectAdapter.Services.External
{
    public class ExternalCityService
    {
        public CityFromExternalService GetCity()
        {
            return new CityFromExternalService
                (
                    "Duluth",
                    "For A Cheapish Haircut",
                    100578
                );
        }
    }
}
