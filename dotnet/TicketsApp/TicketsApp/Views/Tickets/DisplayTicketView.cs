using TicketsApp.Core.Entities;
using TicketsApp.Infrastructure.MVC;
using TicketsApp.Infrastructure.MVC.Interfaces;
using TicketsApp.Infrastructure.MVC.Routes;

namespace TicketsApp.Views.Tickets;

public class DisplayTicketView : IView
{
    protected Ticket Ticket { get; }

    public DisplayTicketView(Ticket ticket)
    {
        Ticket = ticket;
    }

    public RequestContext Render()
    {
        Console.WriteLine($"ID - {Ticket.Id}");
        Console.WriteLine($"Name - {Ticket.Name}");
        Console.WriteLine($"Amount - {Ticket.Amount}");
        Console.WriteLine($"Qty - {Ticket.Qty}");

        Console.WriteLine($"Press any key to return to menu");
        Console.ReadKey();
        return new RequestContext(ViewName.TicketsMenu);
    }
}