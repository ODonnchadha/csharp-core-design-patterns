namespace Adapter.ClassAdapter.Models.External
{
    public class CityFromExternalService
    {
        public string Name { get; private set; }
        public string Nickname { get; private set; }
        public int Inhabitants { get; private set; }
        public CityFromExternalService(string name, string nickname, int inhabitants)
        {
            Name = name;
            Nickname = nickname;
            Inhabitants = inhabitants;
        }
    }
}
