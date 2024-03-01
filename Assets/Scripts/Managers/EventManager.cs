using UnityEngine;
using UnityEngine.Events;

namespace Managers
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager Instance;
        
        public UnityEvent IncreaseScore;
        public UnityEvent PauseGame;
        public UnityEvent ResumeGame;
        public UnityEvent EndGame;
        private void Awake()
        {
            if (Instance != null)
            {
                Debug.Log("EventManager already exists");
                Destroy(this);
            }

            Instance = this;
        }

        public void InvokeIncreaseScore() => IncreaseScore?.Invoke();

        public void InvokePauseGame() => PauseGame?.Invoke();

        public void InvokeResumeGame() => ResumeGame?.Invoke();

        public void InvokeEndGame() => EndGame?.Invoke();
    }
}