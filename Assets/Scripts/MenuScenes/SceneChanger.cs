using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneChanger : MonoBehaviour
{
    [SerializeField] private MenuButtonsEventInvoker _eventHandler;

    private void OnEnable()
    {
        _eventHandler.ChangingScene += ChangeSceneByName;
    }

    private void OnDisable()
    {
        _eventHandler.ChangingScene -= ChangeSceneByName;
    }

    private void ChangeSceneByName(SceneNames name)
    {
        if (name == SceneNames.Exit)
        {
            ExitGame();
        } else
        {
            SceneManager.LoadScene(name.ToString());
        }
    }
    private void ExitGame()
    {
        Application.Quit();
    }
}