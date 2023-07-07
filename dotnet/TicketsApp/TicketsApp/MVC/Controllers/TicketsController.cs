using TicketsApp.Core.Interfaces;
using TicketsApp.Infrastructure.Validation.Interfaces;
using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Models;
using TicketsApp.MVC.Views.Tickets;

namespace TicketsApp.MVC.Controllers;

public class TicketsController : ControllerBase
{
    private readonly ITicketManager _ticketManager;
    public TicketsController(ITicketManager ticketManager, IDataValidationFactory validationFactory)
        : base(validationFactory)
    {
        _ticketManager = ticketManager;
    }

    public IView GetMenuView()
    {
        return new TicketMenuView();
    }

    public IView GetCreateTicketView()
    {
        return new CreateTicketView();
    }

    public IView CreateTicket(IViewModel model)
    {
        var ticketModel = (CreateTicketModel)model;

        if (IsValidModel(ticketModel, out var modelState))
        {
            var ticket = _ticketManager.CreateTicket(ticketModel.Name, ticketModel.Amount, ticketModel.Qty);
            return new DisplayTicketView(ticket);
        }

        return new CreateTicketView(ticketModel, modelState);
    }

    public IView GetTicket(IViewModel model)
    {
        var ticketModel = (GetTicketViewModel)model;
        var ticket = _ticketManager.GetById(ticketModel.Id);
        return new DisplayTicketView(ticket);
    }
}