namespace TicketsApp.Core.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Qty { get; set; }
    }
}
