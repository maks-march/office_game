using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeToScene : MonoBehaviour
{
    [SerializeField] private AnimationEventInvoker _eventInvoker;

    private void OnEnable()
    {
        _eventInvoker.AnimationEnds += LoadMenuScene;
    }

    private void OnDisable()
    {
        _eventInvoker.AnimationEnds -= LoadMenuScene;
    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene(SceneNames.MenuScene.ToString());
    }
}
