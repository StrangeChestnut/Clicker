using System;
using UnityEngine;
using UnityEngine.Events;

public class Gameover : MonoBehaviour
{
    public UnityEvent StopGame;

    private void OnCollisionEnter2D(Collision2D other)
    {
        StopGame?.Invoke();
        Destroy(this);
    }
}
