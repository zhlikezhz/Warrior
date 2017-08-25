using UnityEngine; 

namespace ZFrame
{
    public class GameManager : Manager<GameManager>
    {
        public override void onInit()
        {
            // 初始化资源管理器
            AssetManager.Instance.onInit();

            // 初始化UI管理器
            GameObject uiRoot = GameObject.Find("UIRoot");
            GameObject.DontDestroyOnLoad(uiRoot);
            UIManager.Instance.onInit(uiRoot.transform.Find("Canvas").GetComponent<Canvas>());

            // 初始化场景管理器，并进入初始化场景。
            SceneManager.Instance.onInit();
            SceneManager.Instance.openScene(SceneType.Init);
        }

        public override void onDestroy()
        {
            SceneManager.Instance.onDestroy();
            UIManager.Instance.onDestroy();
            AssetManager.Instance.onDestroy();
        }
    }
}