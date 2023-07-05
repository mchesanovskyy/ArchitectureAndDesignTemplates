namespace TicketsApp.Infrastructure.Interfaces;

public interface IView
{
    RequestContext Render();
}