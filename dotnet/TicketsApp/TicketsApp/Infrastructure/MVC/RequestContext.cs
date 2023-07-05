using TicketsApp.Infrastructure.MVC.Interfaces;
using TicketsApp.Infrastructure.MVC.Routes;

namespace TicketsApp.Infrastructure.MVC;

public class RequestContext
{
    public RequestContext() { }
    public RequestContext(ViewName viewName)
    {
        ViewName = viewName;
    }

    public ViewName ViewName { get; set; }
    public IViewModel Model { get; set; }
}