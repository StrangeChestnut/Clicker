using System;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class MenuWindow : View
    {
        [SerializeField] private Text _nickname;

        public Text Nickname => _nickname;

        public event Action PlayEvent;

        public void Play()
        {
            PlayEvent?.Invoke();
        }
    }
}
