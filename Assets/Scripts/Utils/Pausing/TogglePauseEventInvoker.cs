using UnityEngine;
using System;

public class TogglePauseEventInvoker : MonoBehaviour
{
    public event Action<bool> TogglePauseEvent;

    public void TogglePause() => TogglePauseEvent?.Invoke(Time.timeScale == 0f);
}
