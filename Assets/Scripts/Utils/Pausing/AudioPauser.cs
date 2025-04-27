using UnityEngine;

public class AudioPauser : MonoBehaviour
{
    [SerializeField] private TogglePauseEventInvoker _pauseEventInvoker;

    private AudioSource _source;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _pauseEventInvoker.TogglePauseEvent += TogglePause;
    }

    private void OnDisable()
    {
        _pauseEventInvoker.TogglePauseEvent -= TogglePause;
    }

    private void TogglePause(bool isPaused)
    {
        if (isPaused)
        {
            _source.UnPause();
        }
        else
        {
            _source.Pause();
        }
    }
}
