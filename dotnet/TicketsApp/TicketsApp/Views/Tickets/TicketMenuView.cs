using TicketsApp.Infrastructure;
using TicketsApp.Infrastructure.Interfaces;
using TicketsApp.Infrastructure.Router;

namespace TicketsApp.Views.Tickets;

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

            var key = Console.ReadLine();
            switch (key)
            {
                case "0":
                    return new RequestContext(ViewName.MainMenu);
                case "1":
                    return new RequestContext(ViewName.GetCreateTicketView);
            }
        }
    }
}