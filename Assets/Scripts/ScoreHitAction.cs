using System;
using UnityEngine;


public class ScoreHitAction : HitAction
{
    [SerializeField] private Score score;
    [SerializeField] private CircleCollider2D _collider;

    public override void DoExecute(RaycastHit2D hit2D)
    {
        if (_collider!= hit2D.collider) return;

        var from = gameObject.transform.position;
        var to = hit2D.point;
        
        var difference = Vector2.Distance(from, to);
        var radius = _collider.radius;
        
        score.AddValue(GetValue((int)(100 * (radius - difference) / radius)));
    }

    private int GetValue(int diff)
    {
        return diff < 50 ? 25 : diff < 75 ? 50 : 100;
    }
}
