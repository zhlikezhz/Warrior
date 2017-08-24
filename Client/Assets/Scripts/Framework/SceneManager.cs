using System;
using System.Collections.Generic;

namespace ZFrame
{
    public class SceneManager : Manager<SceneManager>
    {        
        List<SceneBase> _sceneList;

        public override void onInit()
        {
            _sceneList = new List<SceneBase>();
        }

        public override void onDestroy()
        {
            foreach(SceneBase scene in _sceneList)
            {
                scene.onDestroy();
            }
            _sceneList.Clear();
        }


        SceneData getSceneData(SceneType type)
        {
            if (SceneDefine.Scenes.ContainsKey(type))
            {
                return SceneDefine.Scenes[type];
            }
            else
            {
                Log.error(string.Format("scene type not exist {0}, reference SceneType in SceneDefine.cs.", type));
            }
            return null;
        }

        public void openScene(SceneType type)
        {
            if (getSceneData(type) != null)
            {
                SceneData data = getSceneData(type);
                SceneBase scene = Activator.CreateInstance(data.type) as SceneBase; 
                _sceneList.Add(scene);
                scene.onInit(data);
                scene.onStart();
            }
        }

        public void closeScene(SceneBase scene)
        {
            if (_sceneList.Contains(scene))
            {
                _sceneList.Remove(scene);
                scene.onDestroy();
            }
            else
            {
                Log.error("scene not exist");
            }
        }
    }
}