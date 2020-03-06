using UnityEngine;

public abstract class HitAction : MonoBehaviour
{ 
    public abstract void DoExecute(RaycastHit2D hit2D);
}