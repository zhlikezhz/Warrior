using UnityEngine;

namespace ZFrame
{
    public static class UnityPath
    {
        /// <summary>
        /// Unity的StreamingAsset目录，官网文档中规定此目录可读不可写。
        /// 测试后发现：
        /// ios：可读可写。
        /// android：可读不可写，且只能通过WWW读取。
        /// windows：可读可写。
        /// </summary>
        /// <returns></returns>
        public static string streamingPath()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                return Application.dataPath + "/Raw";
            }
            else if (Application.platform == RuntimePlatform.Android)
            {
                return Application.dataPath + "!assets";
            }
            else
            {
                return Application.dataPath + "/StreamingAssets";
            }
        }

        /// <summary>
        /// 用WWW加载StreamingAsset中的资源时，在不同平台的加载路径不一样。
        /// </summary>
        /// <returns></returns>
        public static string streamingPathWWW()
        {
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                return "file://" + Application.dataPath + "/Raw";
            }
            else if (Application.platform == RuntimePlatform.Android)
            {
                return "jar:file://" + Application.dataPath + "!/assets";
            }
            else
            {
                return "file://" + Application.dataPath + "/StreamingAssets";
            }
        }

        /// <summary>
        /// Unity的PresistentAsset目录，官网文档中规定此目录可读可写。
        /// </summary>
        /// <returns></returns>
        public static string presistentPath()
        {
            return Application.persistentDataPath;
        }

        /// <summary>
        /// 用WWW加载PresistentAsset中的资源时，在不同平台的加载路径不一样。
        /// </summary>
        /// <returns></returns>
        public static string presistentPathWWW()
        {
            if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
                return "file:///" + Application.persistentDataPath;
            return "file://" + Application.persistentDataPath;
        }
    }
}