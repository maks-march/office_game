using UnityEngine;


namespace Resources
{
    public static class DynamicResources
    {
        private static float _musicVolume = 0.4f;

        public static float Volume
        {
            get => _musicVolume;
            set
            {
                if (value <= 1 && value >= 0) {
                    _musicVolume = value;
                }
            }
        }
    }
}