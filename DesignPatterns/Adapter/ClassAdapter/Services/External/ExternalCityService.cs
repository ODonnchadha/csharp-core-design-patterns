using Adapter.ClassAdapter.Models.External;

namespace Adapter.ClassAdapter.Services.External
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
