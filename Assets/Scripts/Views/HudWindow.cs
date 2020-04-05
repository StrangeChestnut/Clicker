using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class HudWindow : View
    {
        [SerializeField] private Text _scoreText;
        [SerializeField] private Text _timerText;
    
        public void UpdateScore(int score)
        {
            _scoreText.text = score.ToString();
        }
        
        public void UpdateTimer(int time)
        {
            _timerText.text = time.ToString();
        }
    }
}
