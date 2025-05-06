using UnityEngine;


namespace Pausing
{
    public class GamePauser : IPausable
    {
        public void TogglePause(bool isPaused)
        {
            if (isPaused)
            {
                Time.timeScale = 0f;
            } else
            {
                Time.timeScale = 1f;
            }
        }
    }
}

