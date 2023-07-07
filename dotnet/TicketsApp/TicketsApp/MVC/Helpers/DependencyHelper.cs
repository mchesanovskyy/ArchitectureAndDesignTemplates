using TicketsApp.Core;
using TicketsApp.Infrastructure.FileDataLayer;
using TicketsApp.Infrastructure.Validation;
using TicketsApp.MVC.Controllers;
using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Routes;

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
        var routes = GetRoutes(controllersUoW);
        return new Router(routes);
    }

    private static IReadOnlyCollection<Route> GetRoutes(IControllerUnitOfWork controllerUnitOfWork)
    {
        return new[]
        {
            new Route(ViewName.MainMenu, _ => controllerUnitOfWork.MainController.GetMainMenuView()),

            new Route(ViewName.TicketsMenu, _ => controllerUnitOfWork.TicketsController.GetMenuView()),
            new Route(ViewName.GetCreateTicketView, _ => controllerUnitOfWork.TicketsController.GetCreateTicketView()),
            new Route(ViewName.CreateTicket, ctx => controllerUnitOfWork.TicketsController.CreateTicket(ctx.Model!)),
            new Route(ViewName.GetTicket, ctx => controllerUnitOfWork.TicketsController.GetTicket(ctx.Model!)),
        };
    }
}