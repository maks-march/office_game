using Resources;


namespace Invokers
{
    public class FadeoutEndsInvoker : SceneChangeInvoker
    {
        private PlayerActionsInvoker _actionsInvoker;
        private SceneName _sceneName = SceneName.MenuScene;

        public override SceneName GetSceneName { get => _sceneName; }

        private void Awake()
        {
            _actionsInvoker = new PlayerActionsInvoker();
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
    }
}
