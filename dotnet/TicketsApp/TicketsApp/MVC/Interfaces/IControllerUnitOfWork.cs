using TicketsApp.MVC.Controllers;

namespace TicketsApp.MVC.Interfaces;

public interface IControllerUnitOfWork
{
    MainController MainController { get; }
    TicketsController TicketsController { get; }
}