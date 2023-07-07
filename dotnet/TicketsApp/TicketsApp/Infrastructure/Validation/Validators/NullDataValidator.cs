using TicketsApp.Infrastructure.Validation.Interfaces;
using TicketsApp.MVC.Interfaces;

namespace TicketsApp.Infrastructure.Validation.Validators;

public class NullDataValidator<TViewModel> : IValidator<TViewModel> 
    where TViewModel : IViewModel
{
    public class EmptyViewModel : IViewModel { }

    public ModelState Validate(TViewModel viewModel)
    {
        return new ModelState();
    }
}