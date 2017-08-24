
namespace ZFrame
{
    public class GameManager : Manager<GameManager>
    {
        
        public override void onInit()
        {
            SceneManager.Instance.onInit();
        }

        public override void onDestroy()
        {

        }
    }
}