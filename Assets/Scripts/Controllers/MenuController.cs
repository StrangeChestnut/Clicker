using Views;

namespace Controllers
{
    public class MenuController : IController<MenuWindow>
    {
        private UiManager _ui;

        public MenuController(UiManager uiManager)
        {
            _ui = uiManager;
        }

        public void OnOpen(MenuWindow view)
        {
            view.PlayEvent += _ui.CloseMenu;
            view.PlayEvent += _ui.OpenGame;
        }

        public void OnClose(MenuWindow view)
        {
            view.PlayEvent -= _ui.CloseMenu;
            view.PlayEvent -= _ui.OpenGame;
        }
    }
}
