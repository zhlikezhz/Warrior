using System;
using System.Collections.Generic;
 
namespace ZFrame
{
    public class UIData
    {
        public string name;
        public UIData(string name)
        {
            this.name = name;
        }
    }

    public enum UIType
    {
        None = 0,
        Login = 1,
    }

    public static class UI
    {
        public static Dictionary<UIType, UIData> UIs = new Dictionary<UIType, UIData>()
        {
            {UIType.Login, new UIData("UILogin")},
        };
    }
}

