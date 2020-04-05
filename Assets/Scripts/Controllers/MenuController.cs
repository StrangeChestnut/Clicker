using UnityEngine;
using UnityEngine.UI;
using Views;

namespace Controllers
{
    public class MenuController : IController<MenuWindow>
    {
        private UiManager _ui;
        private Text _nickname;

        public MenuController(UiManager uiManager)
        {
            _ui = uiManager;
        }

        public void OnOpen(MenuWindow view)
        {
            _nickname = view.Nickname;
            view.PlayEvent += OnPlay;
        }

        public void OnClose(MenuWindow view)
        {
            view.PlayEvent -= OnPlay;
        }
        
        private void OnPlay()
        {
            _ui.Game.StartGame(_nickname.text);
        }
    }
}
