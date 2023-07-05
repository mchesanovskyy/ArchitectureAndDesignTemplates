using TicketsApp.Infrastructure.MVC.Interfaces;

namespace TicketsApp.Models
{
    public class CreateTicketModel : IViewModel
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Qty { get; set; }
    }
}
