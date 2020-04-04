using UnityEngine;


public class DestroyHitAction : HitAction
{
    public override void DoExecute(RaycastHit2D hit2D)
    {
        Destroy(gameObject);
    }
}
