using TicketsApp.Infrastructure.Extensions;
using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Models;
using TicketsApp.MVC.Routes;

namespace TicketsApp.MVC.Views.Tickets;

public class TicketMenuView : IView
{
    public RequestContext Render()
    {
        while (true)
        {
            Console.WriteLine("0 - return to Main menu");
            Console.WriteLine("1 - create ticket");
            Console.WriteLine("2 - edit ticket");
            Console.WriteLine("3 {id} - find by id");

            var line = Console.ReadLine();
            if (line == null)
            {
                continue;
            }

            var parts = line.Split(' ');
            var key = parts[0];
            switch (key)
            {
                case "0":
                    return new RequestContext(ViewName.MainMenu);
                case "1":
                    return new RequestContext(ViewName.GetCreateTicketView);
                case "3":
                    var ticketId = parts.ElementAtOrDefault(1).ToType<int>();
                    return new RequestContext(ViewName.GetTicket, new GetTicketViewModel(ticketId));
            }
        }
    }
}