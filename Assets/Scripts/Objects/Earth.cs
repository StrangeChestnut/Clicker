using System;
using UnityEngine;
using UnityEngine.Events;

public class Earth : MonoBehaviour
{
    [SerializeField] private GameController _game;

    private void OnEnable()
    {
        _game.StartEvent += SetEnable;
        _game.StopEvent += SetDisable;
    }

    private void SetDisable()
    {
        enabled = false;
    }

    private void SetEnable()
    {
        enabled = true;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (enabled)
            _game.StopGame();
    }
}
