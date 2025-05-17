using UnityEngine;

namespace Resources
{
    public static class ConstantResources
    {
        public const float BackgroundSpeed = 1f;
        public const float MoveDuration = 0.5f;
        public const SceneName SceneBaseName = SceneName.Null;
        public const string StartTriggerName = "Start";
        public const string AnimatorLayer = "Base";

        public static LayerMask GroundLayer { get => LayerMask.NameToLayer("Objects"); }
    }
}