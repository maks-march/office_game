using UnityEngine;

namespace Resources
{
    public static class ConstantResources
    {
        public const float BackgroundSpeed = 1f;
        public const float MoveDuration = 0.5f;
        public const SceneName SceneBaseName = SceneName.Null;
        public const string StartTriggerName = "Start"; 

        public static LayerMask GroundLayer { get => LayerMask.NameToLayer("Objects"); }
    }
}