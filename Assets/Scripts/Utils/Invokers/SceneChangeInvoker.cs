using Utils.Resources;


namespace Utils.Invokers
{
    public class SceneChangeInvoker : Invoker, ISceneChangeInvoker, IInvoker
    {
        public virtual SceneName GetSceneName { get => ConstantsResources.SceneBaseName; }
    }
}