using UnityEngine;

namespace Managers
{
    public class TimeManager : MonoBehaviour
    {
        public void PauseTime() => Time.timeScale = 0f;
        
        public void ContinueTime() => Time.timeScale = 1f;
    }
}