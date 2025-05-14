using UnityEngine;

namespace Resources
{
    public static class ConstantsResources
    {
        public const float BackgroundSpeed = 1f;
        public const SceneName SceneBaseName = SceneName.Null;
        public const string StartTriggerName = "Start"; 
        public static LayerMask GroundLayer { get => LayerMask.NameToLayer("Objects"); }
    }
}