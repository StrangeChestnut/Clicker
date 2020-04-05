using System;
using System.Collections;
using UnityEngine;

namespace Objects
{
    public class Timer : MonoBehaviour
    {
        [SerializeField] private GameController _game;
        
        private IEnumerator _timer;

        public event Action<int> UpdateTimer;

        private void Awake()
        {
            _game.StartEvent += TimerStart;
            _game.StopEvent += TimerStop;
        }

        private void TimerStart()
        {
            _timer = TimeCoroutine();
            StartCoroutine(_timer);
        }
        private void TimerStop()
        {
            StopCoroutine(_timer);
            _timer = null;
        }
        
        private IEnumerator TimeCoroutine()
        {
            for (int time = _game.Duration; time > 0; time -= 1)
            {
                UpdateTimer?.Invoke(time);
                yield return new WaitForSeconds(1);
            }
            _game.StopGame();
        }
    }
}