using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableOnHold : MonoBehaviour
{
    public GameObject objectToEnable; // Object to enable
    public AudioSource grabSound; // Sound to play on grab & release
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrab);
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true);
        }

        PlaySound();
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        if (objectToEnable != null)
        {
            objectToEnable.SetActive(false);
        }

        PlaySound();
    }

    private void PlaySound()
    {
        if (grabSound != null)
        {
            grabSound.Play(); // Play the same sound on both grab and release
        }
    }
}
