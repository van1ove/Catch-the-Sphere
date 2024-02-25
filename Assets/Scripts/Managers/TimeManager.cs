using UnityEngine;

namespace Managers
{
    public class TimeManager
    {
        public static void PauseTime() => Time.timeScale = 0f;
        
        public static void ContinueTime() => Time.timeScale = 1f;
    }
}