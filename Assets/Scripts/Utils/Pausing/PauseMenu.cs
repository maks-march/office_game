using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private TogglePauseEventInvoker _pauseEventInvoker;

    private bool _isSubscribed = false;

    public void Subscribe()
    {
        if (!_isSubscribed)
        {
            _pauseEventInvoker.TogglePauseEvent += ToggleActive;
            _isSubscribed = true;
        }
    }

    private void OnDestroy()
    {
        _pauseEventInvoker.TogglePauseEvent -= ToggleActive;
        _isSubscribed = true;
    }

    private void ToggleActive(bool isPaused)
    {
        gameObject.SetActive(!isPaused);
    }
}
