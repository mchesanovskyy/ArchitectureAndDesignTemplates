using TicketsApp.MVC.Interfaces;

namespace TicketsApp.Infrastructure.Validation.Interfaces;

public interface IDataValidationFactory
{
    IValidator<TViewModel> Create<TViewModel>()
        where TViewModel : IViewModel;
}