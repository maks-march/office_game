using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using Resources;
using UnityEngine.Rendering;


namespace Audio
{
    public class MixerUtil : MonoBehaviour
    {
        [SerializeField] private AudioMixer _audioMixer;
        [SerializeField] private Slider _volumeSlider;

        private void Start()
        {
            _volumeSlider.onValueChanged.AddListener(SetVolume);
            _volumeSlider.value = DynamicResources.Volume;
            _audioMixer.SetFloat(ConstantResources.MixerMusicVolume, Mathf.Lerp(-80, 0, _volumeSlider.value));
        }

        private void SetVolume(float volume)
        {
            DynamicResources.Volume = volume;
            _audioMixer.SetFloat(ConstantResources.MixerMusicVolume, Mathf.Lerp(-80, 0, volume));
        }
    }
}

