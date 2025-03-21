using UnityEngine;
using UnityEngine.UI;

public class ButtonClickSound : MonoBehaviour
{
    public Button[] buttons; // Drag multiple buttons here in the Inspector
    public AudioSource clickSound; // Drag an AudioSource with the click sound

    private void Start()
    {
        // Loop through all buttons and add a listener to play the sound
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(PlayClickSound);
        }
    }

    private void PlayClickSound()
    {
        if (clickSound != null)
        {
            clickSound.Play();
        }
    }
}
