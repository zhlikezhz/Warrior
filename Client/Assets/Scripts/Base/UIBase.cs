namespace ZFrame
{
    public class UIBase
    {
        protected UIData _uiData;

        public UIType getType()
        {
            return _uiData.uiType;
        }

        public virtual void onInit(UIData uiData)
        {
            _uiData = uiData;
        }

        public virtual void onStart()
        {

        }

        public virtual void onEnter()
        {

        }

        public virtual void onExit()
        {

        }

        public virtual void onDestroy()
        {

        }
    }
}