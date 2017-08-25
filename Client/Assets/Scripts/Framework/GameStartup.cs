using UnityEngine;

namespace ZFrame
{
    public class GameStartup : MonoBehaviour
    {
        void Start()
        {
            GameManager.Instance.onInit();
        }
    }
}