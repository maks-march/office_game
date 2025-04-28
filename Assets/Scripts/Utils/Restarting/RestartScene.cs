using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    public void SceneRestart() => ChangeSceneByName(SceneNames.GameScene);

    private void ChangeSceneByName(SceneNames name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name.ToString());
    }
}
