using TicketsApp.Infrastructure.Interfaces;
using TicketsApp.Views.Main;

namespace TicketsApp.Controllers
{
    public class MainController : IController
    {
        public IView GetMainMenuView()
        {
            return new MainMenuView();
        }
    }
}
