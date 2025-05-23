using UnityEngine;


namespace Pausable
{
    public class ActiveOnPause : MonoBehaviour, IPausable
    {
        public void TogglePause(bool isPaused)
        {
            gameObject.SetActive(isPaused);
        }
    }
}
