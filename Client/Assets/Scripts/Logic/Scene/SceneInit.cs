using System;
using UnityEngine;
using ZFrame;

public class SceneInit : SceneBase
{
    public override void onStart()
    {
        AssetManager.Instance.loadScene("initialize");
        UIBase ui = UIManager.Instance.openUI(UIType.Login);
    }

    public override void onDestroy()
    {

    }
}