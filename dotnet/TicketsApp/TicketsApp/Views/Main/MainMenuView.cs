using TicketsApp.Infrastructure;
using TicketsApp.Infrastructure.Interfaces;
using TicketsApp.Infrastructure.Router;

namespace TicketsApp.Views.Main;

public class MainMenuView : IView
{
    public RequestContext Render()
    {
        while (true)
        {
            Console.WriteLine("1 - Tickets menus");

            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    return new RequestContext(ViewName.TicketsMenu);
            }
        }
    }
}