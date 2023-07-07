using TicketsApp.Infrastructure.Validation;
using TicketsApp.Infrastructure.Validation.Interfaces;
using TicketsApp.MVC.Interfaces;

namespace TicketsApp.MVC.Controllers;

public class ControllerBase : IController
{
    protected IDataValidationFactory ValidationFactory { get; }

    protected ControllerBase(IDataValidationFactory validationFactory)
    {
        ValidationFactory = validationFactory;
    }

    protected bool IsValidModel<TViewModel>(TViewModel viewModel, out ModelState modelState)
        where TViewModel : IViewModel
    {
        var validator = ValidationFactory.Create<TViewModel>();
        modelState = validator.Validate(viewModel);
        return modelState.IsValid;
    }
}