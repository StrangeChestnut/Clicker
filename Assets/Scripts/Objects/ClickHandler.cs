using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private void Handle(RaycastHit2D hit2D)
    {
        if (hit2D.collider == null) return;
        
        var executor = hit2D.collider.gameObject.GetComponent<HitExecutor>();
        if (executor != null) executor.ExecuteAllActions(hit2D);
    }
}
