using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Routes;

namespace TicketsApp.MVC;

public class RequestContext
{
    public RequestContext() { }
    
    public RequestContext(ViewName viewName)
    {
        ViewName = viewName;
    }

    public RequestContext(ViewName viewName, IViewModel? model)
    {
        ViewName = viewName;
        Model = model;
    }

    public ViewName ViewName { get; set; }
    public IViewModel? Model { get; set; }
}