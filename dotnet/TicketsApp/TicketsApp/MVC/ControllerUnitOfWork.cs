using TicketsApp.MVC.Controllers;
using TicketsApp.MVC.Interfaces;

namespace TicketsApp.MVC;

public class ControllerUnitOfWork : IControllerUnitOfWork
{
    public ControllerUnitOfWork(MainController mainController,
        TicketsController ticketsController)
    {
        MainController = mainController;
        TicketsController = ticketsController;
    }

    public MainController MainController { get; }

    public TicketsController TicketsController { get; }
}
