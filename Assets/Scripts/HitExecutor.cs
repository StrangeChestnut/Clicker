using System.Linq;
using UnityEngine;

public class HitExecutor : MonoBehaviour
{
    public HitAction[] Actions = new HitAction[0];
    
    public void ExecuteAllActions(RaycastHit2D hit2D)
    {
        foreach (var action in Actions.Where(action => action != null))
            action.DoExecute(hit2D);
    }
}
