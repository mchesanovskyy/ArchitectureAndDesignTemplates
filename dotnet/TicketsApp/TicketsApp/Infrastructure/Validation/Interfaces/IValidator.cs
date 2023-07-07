using TicketsApp.MVC.Interfaces;

namespace TicketsApp.Infrastructure.Validation.Interfaces;

public interface IValidator<in TViewModel>
    where TViewModel : IViewModel
{
    public ModelState Validate(TViewModel viewModel);
}