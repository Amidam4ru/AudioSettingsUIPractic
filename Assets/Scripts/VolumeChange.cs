using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private AudioMixerGroup _audioGroup;
    [SerializeField] private Slider _slider;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(SetVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(SetVolume);
    }

    private void SetVolume(float volume)
    {
        _audioMixer.SetFloat(_audioGroup.name, Mathf.Log10(volume) * 20);
    }
}