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
            view.RestartEvent += OnRestart;
        }

        public void OnClose(GameOverWindow view)
        {
            view.RestartEvent -= OnRestart;
        }

        private void OnRestart()
        {
            _ui.Game.RestartGame();
        }
    }
}