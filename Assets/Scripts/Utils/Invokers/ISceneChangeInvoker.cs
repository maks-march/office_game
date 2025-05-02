using Utils.Resources;


namespace Utils.Invokers
{
    public interface ISceneChangeInvoker : IInvoker
    {
        public virtual SceneName GetSceneName { get => ConstantsResources.SceneBaseName; }
    }
}