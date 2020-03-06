using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[Serializable] public class HitEvent : UnityEvent<RaycastHit2D> {}

public class ClickEvent : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    public HitEvent DoHit;
    private bool _isBlocked = false;

    private bool _isClick;

    public void Stop()
    {
        _isBlocked = true;
    }

    void Update()
    {
        if (!_isBlocked && Input.GetMouseButtonDown(0))
            DoHit?.Invoke(Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero));
    }
}
