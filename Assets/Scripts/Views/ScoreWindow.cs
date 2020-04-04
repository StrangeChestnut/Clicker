using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class ScoreWindow : View
    {
        [SerializeField] private Text _scoreText;
    
        public void UpdateScore(int score)
        {
            _scoreText.text = score.ToString();
        }
    }
}
