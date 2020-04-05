
using Views;

namespace Controllers
{
    public class GameWindowController : IController<GameWindow>
    {
        private UiManager _ui;
        private HudController _hudController;
    
        public GameWindowController(UiManager uiManager)
        {
            _ui = uiManager;
            _hudController = new HudController(_ui);
        }
    
        public void OnOpen(GameWindow view)
        {
            view.hudWindow.Open(_hudController);
            _ui.Game.StopEvent += _ui.CloseGameWindow;
            _ui.Game.StopEvent += _ui.OpenGameOver;
        }

        public void OnClose(GameWindow view)
        {
            _ui.Game.StopEvent -= _ui.CloseGameWindow;
            _ui.Game.StopEvent -= _ui.OpenGameOver;
            view.hudWindow.Close(_hudController);
        }
    }
}
