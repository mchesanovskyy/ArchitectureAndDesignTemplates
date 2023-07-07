using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Routes;
using TicketsApp.MVC.Views.Helpers;

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

public class ErrorView : IView
{
    public string Message { get; }

    public ErrorView(string message)
    {
        Message = message;
    }

    public RequestContext Render()
    {
        Console.WriteLine(Message);

        ConsoleHelper.WaitForConfirmation();

        return new RequestContext(ViewName.MainMenu);
    }
}