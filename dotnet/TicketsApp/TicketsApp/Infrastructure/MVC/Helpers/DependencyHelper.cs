using TicketsApp.Controllers;
using TicketsApp.Core;
using TicketsApp.Infrastructure.FileDataLayer;

namespace TicketsApp.Infrastructure.MVC.Helpers;

internal static class DependencyHelper
{
    public static Routes.Router ResolveRouter()
    {
        var ticketRepository = new TicketRepository();

        var ticketManager = new TicketManager(ticketRepository);

        var mainController = new MainController();
        var ticketsController = new TicketsController(ticketManager);

        var controllersUoW = new ControllerUnitOfWork(mainController, ticketsController);

        return new Routes.Router(controllersUoW);
    }
}