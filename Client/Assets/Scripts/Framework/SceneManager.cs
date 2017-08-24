
namespace ZFrame
{
    public class SceneManager : Manager<SceneManager>
    {
        public override void onInit()
        {

        }

        public override void onDestroy()
        {

        }

        public void openScene(SceneType type)
        {
            if (SceneDefine.Scenes.ContainsKey(type))
            {
                SceneData data = SceneDefine.Scenes[type];
            }
            else
            {
                Log.error(string.Format("scene type not exist {0}, reference SceneType in SceneDefine.cs.", type));
            }
        }
    }
}