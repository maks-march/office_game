using Resources;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
    public class Audio : MonoBehaviour
    {
        [SerializeField] AudioMixer _audioMixer;

        void Start()
        {
            _audioMixer.SetFloat(ConstantResources.MixerMusicVolume, Mathf.Lerp(-80, 0, DynamicResources.Volume));
        }
    }
}