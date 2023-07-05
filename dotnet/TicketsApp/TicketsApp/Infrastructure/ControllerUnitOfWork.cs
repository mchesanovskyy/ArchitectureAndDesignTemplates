using TicketsApp.Controllers;
using TicketsApp.Infrastructure.Interfaces;

namespace TicketsApp.Infrastructure;

public class ControllerUnitOfWork : IControllerUnitOfWork
{
    public ControllerUnitOfWork()
    {
        MainController = new MainController();
        TicketsController = new TicketsController();
    }

    public MainController MainController { get; }

    public TicketsController TicketsController { get; }
}