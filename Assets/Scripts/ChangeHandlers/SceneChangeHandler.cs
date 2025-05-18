using StateChangers;


namespace Invokers
{
    public class SceneChangeHandler : ChangeHandler
    {
        private SceneChanger GetSceneChanger { get => (SceneChanger)_changer; }

        protected override void Awake()
        {
            base.Awake();
            _changer = new SceneChanger();
        }

        protected override void OnEvent(IInvoker invoker)
        {
            ISceneChangeInvoker sceneInvoker = (ISceneChangeInvoker)invoker;
            GetSceneChanger.ChangeSceneByName(sceneInvoker.GetSceneName);
        }
    }
}
