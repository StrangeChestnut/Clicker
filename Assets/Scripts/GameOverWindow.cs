using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{
    [SerializeField] private Text _scoreText;

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void SetScore(int score)
    {
        _scoreText.text = $"Total score: {score}";
    }

    public void OnQuitButtonClick()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
}
