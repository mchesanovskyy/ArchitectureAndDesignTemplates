using TicketsApp.Core;
using TicketsApp.Infrastructure.Interfaces;
using TicketsApp.Models;
using TicketsApp.Views.Tickets;

namespace TicketsApp.Controllers;

public class TicketsController : IController
{
    private readonly TicketManager _ticketManager = new TicketManager();

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
        var ticketModel = (CreateTicketModelIn)model;
        var ticket = _ticketManager.CreateTicket(ticketModel.Name, ticketModel.Amount, ticketModel.Qty);
        return new DisplayTicketView(ticket);
    }
}