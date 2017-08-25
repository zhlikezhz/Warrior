using System;
using System.Collections.Generic;
 
namespace ZFrame
{
    public class UIData
    {
        public Type type;
        public UIType uiType;
        public UIData(Type type, UIType uiType)
        {
            this.type = type;
            this.uiType = uiType;
        }
    }

    public enum UIType
    {
        None = 0,
        Login = 1,
    }

    public static class UIDefine
    {
        public static Dictionary<UIType, UIData> UIs = new Dictionary<UIType, UIData>()
        {
            {UIType.Login, new UIData(typeof(UILogin), UIType.Login)},
        };
    }
}

