using TicketsApp.Infrastructure.Validation;
using TicketsApp.MVC.Interfaces;

namespace TicketsApp.MVC.Views.Base;

public abstract class ModelStateViewBase : IView
{
    protected ModelStateViewBase()
    {
    }

    protected ModelStateViewBase(ModelState modelState)
    {
        ModelState = modelState;
    }

    protected ModelState? ModelState { get; }

    public abstract RequestContext Render();
}