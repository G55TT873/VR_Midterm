using UnityEngine;

public class EnableObjectAndPlaySoundCurator : MonoBehaviour
{
    public GameObject targetObject; // Object to enable
    public AudioSource audioSource; // Sound to play

    public void EnableAndPlay() // Call this from the UI Button
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true); // Enable the object
        }

        if (audioSource != null)
        {
            audioSource.Play(); // Play the sound
        }
    }
}
