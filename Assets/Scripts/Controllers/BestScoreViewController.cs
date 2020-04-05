using Views;

namespace Controllers
{
    public class BestScoreViewController : IController<BestScoreView>
    {
        private UiManager _ui;
        public BestScoreViewController(UiManager uiManager)
        {
            _ui = uiManager;
        }
        public void OnOpen(BestScoreView view)
        {
            view.SetScore(_ui.Game.Score);
        }

        public void OnClose(BestScoreView view) {}
    }
}