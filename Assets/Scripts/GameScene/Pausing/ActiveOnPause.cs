using UnityEngine;


namespace Pausing
{
    public class ActiveOnPause : MonoBehaviour, IPausable
    {
        public void TogglePause(bool isPaused)
        {
            gameObject.SetActive(isPaused);
        }
    }
}
