using UnityEngine;

public class EnableObjectAndPlaySound : MonoBehaviour
{
    public GameObject targetObject; // The object to enable
    public AudioSource audioSource; // The AudioSource to play the sound

    public void PlaySoundAndEnableObject()
    {
        if (targetObject != null && audioSource != null)
        {
            targetObject.SetActive(true); // Enable the object
            audioSource.Play(); // Play the sound
            StartCoroutine(DisableAfterSound());
        }
    }

    private System.Collections.IEnumerator DisableAfterSound()
    {
        yield return new WaitForSeconds(audioSource.clip.length); // Wait for the sound to finish
        targetObject.SetActive(false); // Disable the object
    }
}
