using TicketsApp.Infrastructure.MVC;
using TicketsApp.Infrastructure.MVC.Interfaces;
using TicketsApp.Infrastructure.MVC.Routes;
using TicketsApp.Models;

namespace TicketsApp.Views.Tickets;

public class CreateTicketView : IView
{
    public CreateTicketView() { }
    public CreateTicketView(CreateTicketModel? ticketModel)
    {
        TicketModel = ticketModel;
    }
    protected CreateTicketModel? TicketModel { get; }

    public RequestContext Render()
    {
        var model = TicketModel ?? new CreateTicketModel();

        Console.Write("Name: ");
        model.Name = Console.ReadLine();

        Console.Write("Amount: ");
        model.Amount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Qty: ");
        model.Qty = Convert.ToInt32(Console.ReadLine());

        return new RequestContext(ViewName.CreateTicket)
        {
            Model = model
        };
    }
}