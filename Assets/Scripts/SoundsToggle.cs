using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundsToggle : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private AudioMixerGroup _audioGroup;
    [SerializeField] private Button _button;

    private bool _isOn;
    private float _maxVolume;
    private float _minVolume;

    private void Awake()
    {
        _isOn = false;
        _maxVolume = 0;
        _minVolume = -80;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(Switch);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(Switch);
    }

    private void Switch()
    {
        if (_isOn == true)
        {
            _audioMixer.SetFloat(_audioGroup.name, _maxVolume);
        }
        else
        {
            _audioMixer.SetFloat(_audioGroup.name, _minVolume);
        }

        _isOn = !_isOn;
    }
}
