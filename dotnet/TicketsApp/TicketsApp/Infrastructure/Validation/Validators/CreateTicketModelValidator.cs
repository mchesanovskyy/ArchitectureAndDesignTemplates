using TicketsApp.Infrastructure.Extensions;
using TicketsApp.Infrastructure.Validation.Interfaces;
using TicketsApp.MVC.Models;

namespace TicketsApp.Infrastructure.Validation.Validators;

public class CreateTicketModelValidator : IValidator<CreateTicketModel>
{
    public ModelState Validate(CreateTicketModel viewModel)
    {
        var state = new ModelState();
        if (viewModel.Name.IsNullOrEmpty())
        {
            state.AddPropertyError(nameof(viewModel.Name), "The 'Name' is missed or invalid");
        }

        if (viewModel.Amount < 0)
        {
            state.AddPropertyError(nameof(viewModel.Amount), "Amount can't be negative");
        }

        if (viewModel.Qty < 0)
        {
            state.AddPropertyError(nameof(viewModel.Qty), "Qty can't be negative");
        }

        return state;
    }
}