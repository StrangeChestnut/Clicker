using UnityEngine;
using Views;

namespace Controllers
{
    public class MenuController : IController<MenuWindow>
    {
        private UiManager _ui;
        private string _nickname;

        public MenuController(UiManager uiManager)
        {
            _ui = uiManager;
        }

        public void OnOpen(MenuWindow view)
        {
            view.PlayEvent += _ui.CloseMenu;
            view.PlayEvent += _ui.OpenGame;
            view.PlayEvent += OnPlay;
        }
        
        public void OnClose(MenuWindow view)
        {
            view.PlayEvent -= _ui.CloseMenu;
            view.PlayEvent -= _ui.OpenGame;
            view.PlayEvent -= OnPlay;
            _nickname = view.Nickname;
        }
        
        private void OnPlay()
        {
            _ui.Game.StartGame(_nickname);
        }
    }
}
