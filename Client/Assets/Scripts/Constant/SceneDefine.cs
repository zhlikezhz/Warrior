using System;
using System.Collections.Generic;
 
namespace ZFrame
{
    public class SceneData
    {
        public Type type;
        public SceneType sceneType;
        public SceneData(Type type, SceneType sceneType)
        {
            this.type = type;
            this.sceneType = sceneType;
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
            {SceneType.Init, new SceneData(typeof(SceneInit), SceneType.Init)},
            {SceneType.Battle, new SceneData(typeof(SceneBattle), SceneType.Battle)},
        };
    }
}