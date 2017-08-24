using System;
using UnityEngine;

namespace ZFrame
{
    public class SceneBase
    {
        SceneData _sceneData;

        public SceneBase(SceneData sceneData)
        {
            _sceneData = sceneData;
        }

        public virtual void onStart()
        {

        }

        public virtual void onDestroy()
        {

        }

        public void loadScene(string sceneName)
        {

        }

        public void unloadScene(string sceneName)
        {

        }

        public void loadSceneAsync(string sceneName)
        {

        }

        public void unloadSceneAsync(string sceneName)
        {

        }
    }
}