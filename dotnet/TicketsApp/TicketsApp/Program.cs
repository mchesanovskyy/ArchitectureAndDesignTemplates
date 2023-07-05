using TicketsApp.Infrastructure;
using TicketsApp.Infrastructure.Router;
using TicketsApp.Infrastructure.Routes;

var controllersUoW = new ControllerUnitOfWork();
var router = new Router(controllersUoW);
var request = new RequestContext(ViewName.MainMenu);

while (true)
{
    var view = router.RouteTo(request);
    request = view.Render();
    Console.Clear();
}