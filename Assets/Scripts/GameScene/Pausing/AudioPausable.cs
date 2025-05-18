using UnityEngine;


namespace Pausing
{
    public class AudioPausable : MonoBehaviour, IPausable
    {
        private AudioSource _source;

        private void Start()
        {
            _source = GetComponent<AudioSource>();
        }

        public void TogglePause(bool isPaused)
        {
            if (isPaused)
            {
                _source.Pause();
            }
            else
            {
                _source.UnPause();
            }
        }
    }
}


