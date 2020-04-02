using System;
using UnityEngine;
using UnityEngine.Events;

public class Gameover : MonoBehaviour
{
    public event Action StopGame;

    private void OnCollisionEnter2D(Collision2D other)
    {
        StopGame?.Invoke();
        enabled = false;
    }
}
