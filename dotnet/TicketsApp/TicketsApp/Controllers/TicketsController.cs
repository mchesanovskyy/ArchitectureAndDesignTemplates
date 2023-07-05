using TicketsApp.Core.Interfaces;
using TicketsApp.Infrastructure.MVC.Interfaces;
using TicketsApp.Models;
using TicketsApp.Views.Tickets;

namespace TicketsApp.Controllers;

public class TicketsController : IController
{
    private readonly ITicketManager _ticketManager;

    public TicketsController(ITicketManager ticketManager)
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
        var ticket = _ticketManager.CreateTicket(ticketModel.Name, ticketModel.Amount, ticketModel.Qty);
        return new DisplayTicketView(ticket);
    }
}