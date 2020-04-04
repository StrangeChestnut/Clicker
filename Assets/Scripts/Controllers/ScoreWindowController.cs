using Views;

namespace Controllers
{
    public class ScoreWindowController : IController<ScoreWindow>
    {
        private UiManager _ui;
    
        public ScoreWindowController(UiManager uiManager)
        {
            _ui = uiManager;
        }
    
        public void OnOpen(ScoreWindow view)
        {
            _ui.Game.UpdateScore += view.UpdateScore;
        }

        public void OnClose(ScoreWindow view)
        {
            _ui.Game.UpdateScore -= view.UpdateScore;
        }
    }
}
