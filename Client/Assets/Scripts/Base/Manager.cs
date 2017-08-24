
namespace ZFrame
{
    public abstract class Manager<T> where T : new()
    {
        static T _instance;

        public static T Instance
        {
            get
            {
                if(_instance == null) 
                {
                    _instance = new T();
                }
                return _instance;
            }
        }

        public virtual void onInit() {}

        public virtual void onDestroy() {}
    }
}