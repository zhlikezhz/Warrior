using System;
using System.Collections.Generic;
 
namespace ZFrame
{
    public class SceneData
    {
        public string name;
        public SceneData(string name)
        {
            this.name = name;
        }
    }
    public enum SceneType
    {
        None = 0,
        Init = 1,
        Battle = 2,
    }

    public static class SceneDefine
    {
        public static Dictionary<SceneType, SceneData> Scenes = new Dictionary<SceneType, SceneData>() 
        { 
            {SceneType.Init, new SceneData("SceneInit")},
            {SceneType.Battle, new SceneData("SceneBattle")},
        };
    }
}