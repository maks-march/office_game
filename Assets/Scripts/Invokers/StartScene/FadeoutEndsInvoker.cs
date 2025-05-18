using Resources;

namespace Invokers
{
    public class FadeoutEndsInvoker : SceneChangeInvoker
    {
        private SceneName _sceneName = SceneName.MenuScene;

        public override SceneName GetSceneName { get => _sceneName; }
    }
}
