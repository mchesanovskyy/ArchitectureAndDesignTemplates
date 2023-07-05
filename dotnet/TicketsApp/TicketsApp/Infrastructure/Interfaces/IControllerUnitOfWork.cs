using TicketsApp.Controllers;

namespace TicketsApp.Infrastructure.Interfaces;

public interface IControllerUnitOfWork
{
    MainController MainController { get; }
    TicketsController TicketsController { get; }
}