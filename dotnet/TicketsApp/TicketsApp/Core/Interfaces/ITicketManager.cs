using TicketsApp.Core.Entities;

namespace TicketsApp.Core.Interfaces;

public interface ITicketManager
{
    Ticket CreateTicket(string name, decimal amount, int qty);
    ICollection<Ticket> GetTickets();
    Ticket GetById(int id);
}