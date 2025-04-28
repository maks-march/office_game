using UnityEngine;
using System;

public class TogglePauseEventInvoker : MonoBehaviour
{
    public event Action<bool> TogglePauseEvent;

    private PlayerActionsInvoker controls;

    public void TogglePause() => TogglePauseEvent?.Invoke(Time.timeScale == 0f);

    private void Awake()
    {
        controls = new PlayerActionsInvoker();
    }

    private void OnEnable()
    {
        controls.UI.Enable();
        controls.UI.PauseAction.performed += ctx => TogglePause();
    }

    private void OnDisable()
    {
        controls.UI.PauseAction.performed -= ctx => TogglePause();
        controls.UI.Disable();
    }

}