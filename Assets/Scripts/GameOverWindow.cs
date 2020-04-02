using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverWindow : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    public event Action RestartEvent;

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void SetScore(int score)
    {
        _scoreText.text = $"Total score: {score}";
    }

    public void RestartButtonClick()
    {
        RestartEvent?.Invoke();
    }
}
