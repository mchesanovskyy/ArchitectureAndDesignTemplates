using TicketsApp.Controllers;
using TicketsApp.Infrastructure.MVC.Interfaces;

namespace TicketsApp.Infrastructure.MVC;

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
