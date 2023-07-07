using TicketsApp.MVC.Interfaces;

namespace TicketsApp.MVC.Routes;

public record Route(ViewName ViewName, Func<RequestContext, IView> GetControllerActionFunc, bool IsAuthorizationRequired = false);