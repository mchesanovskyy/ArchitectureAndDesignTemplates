using TicketsApp.Infrastructure.Interfaces;
using TicketsApp.Infrastructure.Router;

namespace TicketsApp.Infrastructure;

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