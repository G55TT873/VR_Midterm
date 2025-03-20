using UnityEngine;

public class EnableObjectAndPlaySoundCurator : MonoBehaviour
{
    [SerializeField] private GameObject targetObject; // Object to enable
    [SerializeField] private AudioSource audioSource; // Sound to play

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
