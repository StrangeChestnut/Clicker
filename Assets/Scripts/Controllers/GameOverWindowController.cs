using Controllers;

namespace Views
{
    public class GameOverWindowController : IController<GameOverWindow>
    {
        private UiManager _ui;

        public GameOverWindowController(UiManager uiManager)
        {
            _ui = uiManager;
        }
        
        public void OnOpen(GameOverWindow view)
        {
            view.SetScore(_ui.Game.ScoreValue);
            
            view.RestartEvent += _ui.CloseGameOverWindow;
            view.MenuEvent += _ui.CloseGameOverWindow;
            view.RestartEvent += _ui.OpenGame;
            view.MenuEvent += _ui.OpenMenu;
        }

        public void OnClose(GameOverWindow view)
        {
            view.RestartEvent -= _ui.CloseGameOverWindow;
            view.MenuEvent -= _ui.CloseGameOverWindow;
            view.RestartEvent -= _ui.OpenGame;
            view.MenuEvent -= _ui.OpenMenu;
        }
    }
}