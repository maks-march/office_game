using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutScript : MonoBehaviour
{
    [SerializeField] private AnimationEventInvoker _eventHandler;

    private void OnEnable()
    {
        _eventHandler.AnimationEnds += LoadMenuScene;
    }

    private void OnDisable()
    {
        _eventHandler.AnimationEnds -= LoadMenuScene;
    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene(SceneNames.MenuScene.ToString());
    }
}
