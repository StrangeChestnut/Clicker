using Controllers;
using UnityEngine;

public class View : MonoBehaviour
{
    public void Open<T>(IController<T> controller) where T : View
    {
        if (this is T view)
            controller.OnOpen(view);
        gameObject.SetActive(true);
    }

    public void Close<T>(IController<T> controller)where T : View
    {
        gameObject.SetActive(false);
        if (this is T view)
            controller.OnClose(view);
    }
}
