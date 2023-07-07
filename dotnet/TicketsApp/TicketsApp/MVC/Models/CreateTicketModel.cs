using TicketsApp.MVC.Interfaces;

namespace TicketsApp.MVC.Models
{
    public class CreateTicketModel : IViewModel
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int Qty { get; set; }
    }

    public class GetTicketViewModel : IViewModel
    {
        public GetTicketViewModel(int ticketId)
        {
            Id = ticketId;
        }

        public int Id { get; set; }
    }
}
