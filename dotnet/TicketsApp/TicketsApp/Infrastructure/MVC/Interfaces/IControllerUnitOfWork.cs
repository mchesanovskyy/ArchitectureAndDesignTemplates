using TicketsApp.Controllers;

namespace TicketsApp.Infrastructure.MVC.Interfaces;

public interface IControllerUnitOfWork
{
    MainController MainController { get; }
    TicketsController TicketsController { get; }
}