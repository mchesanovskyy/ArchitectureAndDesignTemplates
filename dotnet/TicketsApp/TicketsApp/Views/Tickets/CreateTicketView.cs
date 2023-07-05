using TicketsApp.Core;
using TicketsApp.Infrastructure;
using TicketsApp.Infrastructure.Interfaces;
using TicketsApp.Infrastructure.Router;
using TicketsApp.Models;

namespace TicketsApp.Views.Tickets;

public class CreateTicketView : IView
{
    public RequestContext Render()
    {
        var model = new CreateTicketModelIn();
        Console.Write("Name: ");
        model.Name = Console.ReadLine();

        Console.Write("Amount: ");
        model.Amount = Convert.ToDecimal(Console.ReadLine());
        
        Console.Write("Qty: ");
        model.Qty = Convert.ToInt32(Console.ReadLine());

        return new RequestContext(ViewName.CreateTicket)
        {
            Model = model
        };
    }
}

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