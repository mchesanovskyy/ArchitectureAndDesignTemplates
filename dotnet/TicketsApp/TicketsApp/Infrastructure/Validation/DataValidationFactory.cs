using TicketsApp.Infrastructure.Validation.Interfaces;
using TicketsApp.Infrastructure.Validation.Validators;
using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Models;

namespace TicketsApp.Infrastructure.Validation;

public class DataValidationFactory : IDataValidationFactory
{
    public DataValidationFactory()
    {

    }

    public IValidator<TViewModel> Create<TViewModel>()
        where TViewModel : IViewModel
    {
        if (typeof(TViewModel) == typeof(CreateTicketModel))
        {
            return (IValidator<TViewModel>)new CreateTicketModelValidator();
        }

        return new NullDataValidator<TViewModel>();
    }
}