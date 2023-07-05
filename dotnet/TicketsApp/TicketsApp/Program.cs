using TicketsApp.Infrastructure;
using TicketsApp.Infrastructure.MVC;
using TicketsApp.Infrastructure.MVC.Helpers;
using TicketsApp.Infrastructure.MVC.Routes;


var router = DependencyHelper.ResolveRouter();
var request = new RequestContext(ViewName.MainMenu);

while (true)
{
    var view = router.RouteTo(request);
    request = view.Render();
    Console.Clear();
}