using System;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class GameOverWindow : View
    {
        [SerializeField] private Text _scoreText;
        public event Action RestartEvent;

        public void SetScore(int score)
        {
            _scoreText.text = $"Total score: {score}";
        }

        public void Restart()
        {
            RestartEvent?.Invoke();
        }
    }
}
