using System;
using System.Collections.Generic;

namespace ZFrame
{
    public class UIManager : Manager<UIManager>
    {
        List<UIBase> _uiList;
        Stack<UIBase> _uiStack;

        public override void onInit()
        {
            _uiList = new List<UIBase>();
            _uiStack = new Stack<UIBase>();
        }

        public override void onDestroy()
        {
            foreach(UIBase ui in _uiList)
            {
                ui.onDestroy();
            }
            _uiList.Clear();
            _uiStack.Clear(); 
        }

        UIData getUIData(UIType type)
        {
            if (UIDefine.UIs.ContainsKey(type))
            {
                return UIDefine.UIs[type];
            }
            else
            {
                Log.error(string.Format("ui type not exist {0}, reference UIType in UIDefine.cs.", type));
            }
            return null;
        }

        public UIBase openUI(UIType type)
        {
            if (getUIData(type) != null)
            {
                UIData data = getUIData(type);
                UIBase ui = Activator.CreateInstance(data.type) as UIBase; 
                _uiList.Add(ui);
                ui.onInit(data);
                ui.onStart();
                return ui;
            }
            return null;
        }

        public void closeUI(UIBase ui)
        {
            if (_uiList.Contains(ui))
            {
                _uiList.Remove(ui);
                ui.onDestroy();
            }
            else
            {
                Log.error("ui not exist");
            }
        }

        public void closeUI(UIType type)
        {
            closeUI(getUI(type));
        }

        public UIBase getUI(UIType type)
        {
            if (getUIData(type) != null)
            {
                UIData data = getUIData(type);
                foreach(UIBase ui in _uiList)
                {
                    if (ui.getType() == data.type)
                    {
                        return ui;
                    }
                }
            }
            return null;
        }

        public void pushUI(UIBase ui)
        {
            _uiStack.Push(ui);
        }

        public void popUI()
        {
            _uiStack.Pop();
        }
    }
}