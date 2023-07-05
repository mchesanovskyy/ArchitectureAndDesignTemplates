namespace TicketsApp.Infrastructure.MVC.Interfaces;

public interface IView
{
    RequestContext Render();
}