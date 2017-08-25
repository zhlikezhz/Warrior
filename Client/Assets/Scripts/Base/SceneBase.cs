using System;
using UnityEngine;

namespace ZFrame
{
    public class SceneBase
    {
        protected SceneData _sceneData;

        public SceneType getType()
        {
            return _sceneData.sceneType;
        }

        public virtual void onInit(SceneData sceneData)
        {
            _sceneData = sceneData;
        }

        public virtual void onStart()
        {

        }

        public virtual void onDestroy()
        {

        }
    }
}