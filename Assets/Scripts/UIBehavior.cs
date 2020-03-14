using UnityEngine;
using UnityEngine.UI;

public class UIBehavior : MonoBehaviour
{
    [SerializeField] private GameOverWindow _gameOverWindow;
    [SerializeField] private ScoreScriptableObject scoreScriptableObject;
    [SerializeField] private Text _scoreText;

    private void Awake()
    {
        scoreScriptableObject.UpdateScore += UpdateScore;
    }
    
    private void OnEnable()
    {
        UpdateScore(scoreScriptableObject.Count);
    }


    private void UpdateScore(int score)
    {
        _scoreText.text = score.ToString();
        _gameOverWindow.SetScore(score);
    }
}
