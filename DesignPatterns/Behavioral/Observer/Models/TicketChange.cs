namespace Observer.Models
{
    public class TicketChange
    {
        public int Amount { get; private set; }
        public int ArtistId { get; private set; }
        public TicketChange(int id, int amount)
        {
            Amount = amount;
            ArtistId = id;
        }
    }
}
