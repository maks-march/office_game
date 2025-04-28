using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauser : MonoBehaviour
{
    [SerializeField] private TogglePauseEventInvoker _pauseEventInvoker;

    public void TogglePause() => TogglePause(); 

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
        Time.timeScale = 1 - Time.timeScale;
    }
}
