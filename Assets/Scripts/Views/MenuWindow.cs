using System;
using UnityEngine;

namespace Views
{
    public class MenuWindow : View
    {
        public event Action PlayEvent;

        public void Play()
        {
            PlayEvent?.Invoke();
        }
    }
}
