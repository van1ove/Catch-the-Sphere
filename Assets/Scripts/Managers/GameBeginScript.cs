using UnityEngine;

namespace Managers
{
    public class GameBeginScript : MonoBehaviour
    {
        private void Update()
        {
            if (Input.touchCount != 1) return;
        
            EventManager.Instance.InvokeStartGame();
            gameObject.SetActive(false);
        }
    }
}
