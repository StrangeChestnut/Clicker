
namespace Controllers
{
     public interface IController<in TView> where  TView : View
     {
          void OnOpen(TView view);
          void OnClose(TView view);
     }
}
