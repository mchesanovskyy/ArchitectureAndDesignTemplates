using TicketsApp.Infrastructure.MVC;
using TicketsApp.Infrastructure.MVC.Interfaces;
using TicketsApp.Infrastructure.MVC.Routes;

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