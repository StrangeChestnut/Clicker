using System;
using UnityEngine;
using UnityEngine.Events;

public class Earth : MonoBehaviour
{
    [SerializeField] private GameController _game;

    private void OnCollisionEnter2D(Collision2D other)
    {
        _game.StopGame();
        enabled = false;
    }
}
