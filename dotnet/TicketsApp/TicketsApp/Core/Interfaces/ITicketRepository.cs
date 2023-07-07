using TicketsApp.Core.Entities;

namespace TicketsApp.Core.Interfaces;

public interface ITicketRepository
{
    Ticket Add(Ticket ticket);
    ICollection<Ticket> GetCollection();
    Ticket? GetById(int id);
}