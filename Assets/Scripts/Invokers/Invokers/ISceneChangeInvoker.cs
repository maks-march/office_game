using Resources;


namespace Invokers
{
    public interface ISceneChangeInvoker : IInvoker
    {
        public virtual SceneName GetSceneName { get => ConstantsResources.SceneBaseName; }
    }
}