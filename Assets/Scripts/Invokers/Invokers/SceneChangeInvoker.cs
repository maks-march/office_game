using Resources;


namespace Invokers
{
    public class SceneChangeInvoker : Invoker, ISceneChangeInvoker
    {
        public virtual SceneName GetSceneName { get => ConstantResources.SceneBaseName; }
    }
}