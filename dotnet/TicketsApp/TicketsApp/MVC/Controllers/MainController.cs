using TicketsApp.MVC.Interfaces;
using TicketsApp.MVC.Views.Main;

namespace TicketsApp.MVC.Controllers
{
    public class MainController : IController
    {
        public IView GetMainMenuView()
        {
            return new MainMenuView();
        }
    }
}
