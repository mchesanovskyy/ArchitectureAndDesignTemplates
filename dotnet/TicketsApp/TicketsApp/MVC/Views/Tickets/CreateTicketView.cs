using TicketsApp.Infrastructure.Validation;
using TicketsApp.MVC.Models;
using TicketsApp.MVC.Routes;
using TicketsApp.MVC.Views.Base;
using TicketsApp.MVC.Views.Helpers;

namespace TicketsApp.MVC.Views.Tickets;

public class CreateTicketView : ModelStateViewBase
{
    public CreateTicketView() { }

    public CreateTicketView(CreateTicketModel? ticketModel, ModelState modelState)
        : base(modelState)
    {
        TicketModel = ticketModel;
    }

    protected CreateTicketModel? TicketModel { get; }

    public override RequestContext Render()
    {
        var model = TicketModel ?? new CreateTicketModel();

        ConsoleHelper.ReadParameterIfInvalid("Name: ", nameof(CreateTicketModel.Name), ModelState,
            value => model.Name = value);

        ConsoleHelper.ReadParameterIfInvalid<decimal>("Amount: ", nameof(CreateTicketModel.Amount), ModelState,
            value => model.Amount = value);

        ConsoleHelper.ReadParameterIfInvalid<int>("Qty: ", nameof(CreateTicketModel.Qty), ModelState,
            value => model.Qty = value);

        return new RequestContext(ViewName.CreateTicket)
        {
            Model = model
        };
    }
}