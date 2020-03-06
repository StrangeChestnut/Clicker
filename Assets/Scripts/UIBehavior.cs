using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    [SerializeField] private GameOverWindow _gameOverWindow;
    [SerializeField] private Score _score;
    [SerializeField] private Text _scoreText;

    private void Awake()
    {
        _score.UpdateScore += UpdateScore;
    }
    
    private void OnEnable()
    {
        UpdateScore(_score.Count);
    }


    private void UpdateScore(int score)
    {
        _scoreText.text = score.ToString();
        _gameOverWindow.SetScore(score);
    }
}
