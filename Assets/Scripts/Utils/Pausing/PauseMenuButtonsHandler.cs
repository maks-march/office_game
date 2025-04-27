using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButtonsHandler : MonoBehaviour
{
    [SerializeField] private TogglePauseEventInvoker _pauseEventInvoker;
    public void ChangeToMenu() => ChangeSceneByName(SceneNames.MenuScene);

    private void ChangeSceneByName(SceneNames name)
    {
        _pauseEventInvoker.TogglePause();
        SceneManager.LoadScene(name.ToString());
    }
}
