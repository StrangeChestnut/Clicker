using Objects;
using UnityEngine;
using UnityEngine.UI;

namespace Views
{
    public class BestScoreView : View
    {
        [SerializeField] private Text _player;
        [SerializeField] private Text _score;

        public void SetScore(ScoreScriptableObject gameScore)
        {
            _player.text = gameScore.BestPlayer;
            _score.text = gameScore.BestScore.ToString();
        }
    }
}