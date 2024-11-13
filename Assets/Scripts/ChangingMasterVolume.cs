using UnityEngine;
using UnityEngine.Audio;

public class ChangingMasterVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    private bool _isOn;
    private float _maxVolume;
    private float _minVolume;

    private void Awake()
    {
        _isOn = false;
        _maxVolume = 0;
        _minVolume = -80;
    }

    public void SetMasterVolume(float volume)
    {
        _audioMixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
    }

    public void SetButtonsVolume(float volume)
    {
        _audioMixer.SetFloat("ButtonsVolume", Mathf.Log10(volume) * 20);
    }

    public void SetBackgroundVolume(float volume)
    {
        _audioMixer.SetFloat("BackgroundVolume", Mathf.Log10(volume) * 20);
    }

    public void ToggleSounds()
    {
        if (_isOn)
        {
            _audioMixer.SetFloat("MasterVolume", _maxVolume);
        }
        else
        {
            _audioMixer.SetFloat("MasterVolume", _minVolume);
        }

        _isOn = !_isOn;
    }
}