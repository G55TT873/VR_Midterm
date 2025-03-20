using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioSource targetAudioSource; // Assign the specific AudioSource
    public Slider volumeSlider; // Assign the UI Slider

    private void Start()
    {
        if (volumeSlider != null && targetAudioSource != null)
        {
            volumeSlider.value = targetAudioSource.volume; // Set slider to current volume
            volumeSlider.onValueChanged.AddListener(SetVolume); // Add listener for changes
        }
        else
        {
            Debug.LogError("VolumeControl: Missing AudioSource or Slider reference.");
        }
    }

    private void SetVolume(float volume)
    {
        if (targetAudioSource != null)
        {
            targetAudioSource.volume = volume; // Adjust volume based on slider
        }
    }
}
