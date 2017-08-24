using System.Collections.Generic;

namespace ZFrame
{
    public enum LogType
    {
        None = 0,
        Info = 1,
        Warn = 2,
        Error = 3,
        Fatal = 4,
    }

    public enum FilterType
    {
        None = 0,
        Zouhao = 1,
    }

    public static class LogDefine
    {
        public static Dictionary<LogType, string> log2str = new Dictionary<LogType, string>() {
            {LogType.None, "None"},
            {LogType.Info, "Info"},
            {LogType.Warn, "Warn"},
            {LogType.Error, "Error"},
            {LogType.Fatal, "Fatal"},
        };
        public static Dictionary<FilterType, string> filter2str = new Dictionary<FilterType, string>() {
            {FilterType.None, "None"},
            {FilterType.Zouhao, "Zouhao"},
        };
    }
}