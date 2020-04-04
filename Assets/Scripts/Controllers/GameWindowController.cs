
using Views;

namespace Controllers
{
    public class GameWindowController : IController<GameWindow>
    {
        private UiManager _ui;
        private ScoreWindowController _scoreWindowController;
    
        public GameWindowController(UiManager uiManager)
        {
            _ui = uiManager;
            _scoreWindowController = new ScoreWindowController(_ui);
        }
    
        public void OnOpen(GameWindow view)
        {
            view.scoreWindow.Open(_scoreWindowController);
            _ui.Game.GameOver += _ui.CloseGameWindow;
            _ui.Game.GameOver += _ui.OpenGameOver;
            _ui.Game.StartGame();
        }

        public void OnClose(GameWindow view)
        {
            _ui.Game.GameOver -= _ui.CloseGameWindow;
            _ui.Game.GameOver -= _ui.OpenGameOver;
            view.scoreWindow.Close(_scoreWindowController);
        }
    }
}
