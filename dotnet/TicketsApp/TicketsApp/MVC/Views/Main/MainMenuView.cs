using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Routes;

namespace TicketsApp.MVC.Views.Main;

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