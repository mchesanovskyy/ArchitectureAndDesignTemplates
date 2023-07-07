using TicketsApp.MVC;
using TicketsApp.MVC.Helpers;
using TicketsApp.MVC.Routes;

var router = DependencyHelper.ResolveRouter();
var request = new RequestContext(ViewName.MainMenu);

while (true)
{
    var view = router.RouteTo(request);
    request = view.Render();
    Console.Clear();
}