﻿using System;
using System.Collections;
using Objects;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ScoreScriptableObject _score;
    [SerializeField] private Timer _timer;
    
    [SerializeField] private bool _resetOnNewGame = true;
    [SerializeField] private int _gameDuration;

    public Timer Timer => _timer;
    public ScoreScriptableObject Score => _score;
    
    public int ScoreValue => _score.Value;
    public int Duration => _gameDuration;

    public event Action StartEvent;
    public event Action StopEvent;
    
    public void StartGame()
    {
        if (_resetOnNewGame)
        {
            _score.Value = 0;
        }

        _score.Update();
        StartEvent?.Invoke();
    }
    
    public void StopGame()
    {
        StopEvent?.Invoke();
    }
}
