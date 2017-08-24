using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace ZFrame
{
    public class AssetData
    {
        public string name = "";
        public Object root = null;
    }

    public class AssetManager : Manager<AssetManager>
    {
        Dictionary<string, AssetData> _assetPool;

        public override void onInit()
        {
            _assetPool = new Dictionary<string, AssetData>();
        }

        public override void onDestroy()
        {
            foreach(var asset in _assetPool)
            {
                Object.Destroy(asset.Value.root);
            }
            _assetPool.Clear();
        }

        public void loadAsset(string assetPath)
        {
            loadAsset(assetPath, typeof(Object));
        }

        public Object loadAsset(string assetPath, System.Type type)
        {
            assetPath = assetPath.ToLower();
            if (_assetPool.ContainsKey(assetPath)) 
            {
                return _assetPool[assetPath].root;
            }

            AssetData asset = new AssetData();
            asset.root = UnityEditor.AssetDatabase.LoadAssetAtPath(assetPath, type);
            asset.name = assetPath;
            return asset.root;
        }

        public void unloadAsset(string assetPath)
        {
            assetPath = assetPath.ToLower();
            if (_assetPool.ContainsKey(assetPath))
            {
                Object.Destroy(_assetPool[assetPath].root);
                _assetPool.Remove(assetPath);
            }
        }

        public void loadScene(string sceneName)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }

        public void unloadScene(string sceneName)
        {
            UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName);
        }
    }
}