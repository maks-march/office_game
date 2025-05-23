using UnityEngine;
using Resources;


namespace Invokers
{
    public class ButtonSceneChangeInvoker : SceneChangeInvoker
    {
        [SerializeField] private SceneName _newScene;

        public override SceneName GetSceneName { get => _newScene; }
    }
}
