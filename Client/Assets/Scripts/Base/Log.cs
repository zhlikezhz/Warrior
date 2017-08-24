using UnityEngine;

namespace ZFrame
{
    public class Log
    {
        static string format(string str, LogType logType, FilterType filterType)
        {
            return string.Format("[{0}] [{1}]: {2}", str, LogDefine.log2str[logType], LogDefine.filter2str[filterType]);
        }

        public static void info(string str, FilterType type = FilterType.None)
        {
            Debug.Log(format(str, LogType.Info, type));
        }

        public static void warn(string str, FilterType type = FilterType.None)
        {
            Debug.LogWarning(format(str, LogType.Warn, type));
        }

        public static void error(string str, FilterType type = FilterType.None)
        {
            Debug.LogError(format(str, LogType.Error, type));
        }

        public static void fatal(string str, FilterType type = FilterType.None)
        {
            Debug.LogError(format(str, LogType.Fatal, type));
        }
    }
}