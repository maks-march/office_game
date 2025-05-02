using UnityEngine;
using Utils.Resources;

namespace Utils.Invokers
{
    public class ButtonSceneChangeInvoker : SceneChangeInvoker
    {
        [SerializeField] private SceneName _newScene;

        public override SceneName GetSceneName { get => _newScene; }
    }
}
