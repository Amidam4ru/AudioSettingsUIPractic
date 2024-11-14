using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class SoundButton : MonoBehaviour
{
    [SerializeField] private Button _button;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(PlayOneShot);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlayOneShot);
    }

    private void PlayOneShot()
    {
        _audioSource.PlayOneShot(_audioSource.clip);
    }
}
