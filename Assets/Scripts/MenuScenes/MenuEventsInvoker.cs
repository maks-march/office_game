using System;
using UnityEngine;

public class MenuEventsInvoker : MonoBehaviour
{
    public event Action<SceneNames> ChangingScene;

    public void TriggerSceneToGameChange()
    {
        ChangingScene?.Invoke(SceneNames.GameScene);
    }

    public void TriggerSceneToSettingsChange()
    {
        ChangingScene?.Invoke(SceneNames.SettingsScene);
    }
    public void TriggerSceneToMenuChange()
    {
        ChangingScene?.Invoke(SceneNames.MenuScene);
    }

    public void TriggerExitGame()
    {
        ChangingScene?.Invoke(SceneNames.Exit);
    }
}