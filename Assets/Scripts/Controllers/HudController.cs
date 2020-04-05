using UnityEngine;
using Views;

namespace Controllers
{
    public class HudController : IController<HudWindow>
    {
        private UiManager _ui;
    
        public HudController(UiManager uiManager)
        {
            _ui = uiManager;
        }
    
        public void OnOpen(HudWindow view)
        {
            _ui.Game.Score.UpdateScore += view.UpdateScore;
            _ui.Game.Timer.UpdateTimer += view.UpdateTimer;
        }

        public void OnClose(HudWindow view)
        {
            _ui.Game.Score.UpdateScore -= view.UpdateScore;
            _ui.Game.Timer.UpdateTimer -= view.UpdateTimer;
        }
    }
}
