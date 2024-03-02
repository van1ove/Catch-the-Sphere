using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Managers
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager Instance;
        
        [FormerlySerializedAs("IncreaseScore")] public UnityEvent increaseScore;
        [FormerlySerializedAs("PauseGame")] public UnityEvent pauseGame;
        [FormerlySerializedAs("ResumeGame")] public UnityEvent resumeGame;
        [FormerlySerializedAs("EndGame")] public UnityEvent endGame;
        [FormerlySerializedAs("StartGame")] public UnityEvent startGame;
        private void Awake()
        {
            if (Instance != null)
            {
                Debug.Log("EventManager already exists");
                Destroy(this);
            }

            Instance = this;
            InvokePauseGame();
        }

        public void InvokeIncreaseScore() => increaseScore?.Invoke();

        public void InvokePauseGame() => pauseGame?.Invoke();

        public void InvokeResumeGame() => resumeGame?.Invoke();

        public void InvokeEndGame() => endGame?.Invoke();

        public void InvokeStartGame() => startGame?.Invoke();
    }
}