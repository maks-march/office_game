using UnityEngine;
using Utils.Invokers;
using Utils.Resources;


namespace Utils.StateChangers
{
    public class RestartScene : SceneChanger
    {
        private SceneName _restartToScene = SceneName.GameScene;
        private PauseInvoker _pauseInvoker;

        public RestartScene(PauseInvoker pauseInvoker)
        {
            _pauseInvoker = pauseInvoker;
        }

        public void Restart()
        {
            _pauseInvoker.Invoke();
            ChangeSceneByName(_restartToScene);
        }
    }
}
