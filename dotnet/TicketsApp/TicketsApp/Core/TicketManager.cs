using TicketsApp.Core.Entities;
using TicketsApp.Core.Interfaces;

namespace TicketsApp.Core
{
    public class TicketManager : ITicketManager
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Ticket CreateTicket(string name, decimal amount, int qty)
        {
            var ticket = new Ticket
            {
                Name = name,
                Amount = amount,
                Qty = qty,
            };

            return _ticketRepository.Add(ticket);
        }

        public ICollection<Ticket> GetTickets() 
            => _ticketRepository.GetCollection();

        public Ticket GetById(int id)
        {
            return _ticketRepository.GetById(id)
                ?? throw new Exception("Can't find ticket");
        }
    }
}
