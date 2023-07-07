using TicketsApp.Infrastructure.Extensions;
using TicketsApp.MVC.Interfaces;

namespace TicketsApp.MVC.Routes;

public class Router
{
    private readonly IControllerUnitOfWork _controllerUnitOfWork;
    public Router(IControllerUnitOfWork controllerUnitOfWork)
    {
        _controllerUnitOfWork = controllerUnitOfWork;
    }

    public IView RouteTo(RequestContext context)
    {
        switch (context.ViewName)
        {
            case ViewName.MainMenu:
                return _controllerUnitOfWork.MainController.GetMainMenuView();
            case ViewName.TicketsMenu:
                return _controllerUnitOfWork.TicketsController.GetMenuView();
            case ViewName.GetCreateTicketView:
                return _controllerUnitOfWork.TicketsController.GetCreateTicketView();
            case ViewName.CreateTicket:
                return _controllerUnitOfWork.TicketsController.CreateTicket(context.Model);
            case ViewName.GetTicket:
                return _controllerUnitOfWork.TicketsController.GetTicket(context.Model);
            default:
                throw new ArgumentOutOfRangeException();
        }

    }
}