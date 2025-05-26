using Resources;
using UnityEngine;
using UnityEngine.Video;

namespace Invokers
{
    public class IntroEndsInvoker : SceneChangeInvoker
    {
        [SerializeField] private VideoPlayer _videoPlayer;
        private PlayerActionsInvoker _actionsInvoker;
        private SceneName _sceneName = SceneName.MenuScene;

        public override SceneName GetSceneName { get => _sceneName; }

        private void Awake()
        {
            _actionsInvoker = new PlayerActionsInvoker();
            _videoPlayer.loopPointReached += OnFinished;
        }

        private void OnEnable()
        {
            _actionsInvoker.UI.Enable();
            _actionsInvoker.UI.PauseAction.performed += ctx => Invoke();
        }

        private void OnDisable()
        {
            _actionsInvoker.UI.PauseAction.performed -= ctx => Invoke();
            _actionsInvoker.UI.Disable();
        }

        public void PlayVideo()
        {
            _videoPlayer.Play();
        }

        private void OnFinished(VideoPlayer player)
        {
            Invoke();
        }
    }
}
