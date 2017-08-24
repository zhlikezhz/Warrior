namespace ZFrame
{
    public class UIBase
    {
        protected UIData _uiData;

        public System.Type getType()
        {
            return _uiData.type;
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