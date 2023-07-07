using System.Collections.Generic;
using TicketsApp.Infrastructure.Extensions;
using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Views.Main;

namespace TicketsApp.MVC.Routes;

public class Router
{
    private readonly IReadOnlyCollection<Route> _routes;
    public Router(IReadOnlyCollection<Route> routes)
    {
        _routes = routes;
    }

    public IView RouteTo(RequestContext context)
    {
        var route = _routes.FirstOrDefault(r => r.ViewName == context.ViewName);
        return route?.GetControllerActionFunc(context)
               ?? new ErrorView("Can't find view");
    }
}