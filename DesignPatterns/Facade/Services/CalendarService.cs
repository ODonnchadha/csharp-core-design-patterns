namespace Facade.Services
{
    public class CalendarService
    {
        public double Week()
        {
            switch(DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    return 0.8;
                default:
                    return 1.2;
            }
        }
    }
}
