using TicketsApp.Core;
using TicketsApp.Infrastructure.FileDataLayer;
using TicketsApp.Infrastructure.Validation;
using TicketsApp.MVC.Controllers;

namespace TicketsApp.MVC.Helpers;

internal static class DependencyHelper
{
    public static Routes.Router ResolveRouter()
    {
        var ticketRepository = new TicketRepository();

        var ticketManager = new TicketManager(ticketRepository);

        var dataValidationFactory = new DataValidationFactory();

        var mainController = new MainController();
        var ticketsController = new TicketsController(ticketManager, dataValidationFactory);

        var controllersUoW = new ControllerUnitOfWork(mainController, ticketsController);

        return new Routes.Router(controllersUoW);
    }
}