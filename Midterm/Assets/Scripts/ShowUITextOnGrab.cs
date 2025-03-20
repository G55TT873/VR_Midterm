using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowUITextAndLightOnGrab : MonoBehaviour
{
    public XRGrabInteractable grabInteractable; // The grabbable component
    public GameObject uiText; // UI element to toggle
    public Light grabLight; // Light component to enable/disable

    private bool isGrabbed = false;

    private void Start()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.AddListener(OnGrab);
            grabInteractable.selectExited.AddListener(OnRelease);
        }

        if (uiText != null)
            uiText.SetActive(false); // Ensure UI starts hidden

        if (grabLight != null)
            grabLight.enabled = false; // Ensure light is off by default
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        // Check if grabbed by a direct interactor (hand/controller) and NOT a socket
        if (args.interactorObject is XRDirectInteractor || args.interactorObject is XRRayInteractor)
        {
            isGrabbed = true;
            if (uiText != null)
                uiText.SetActive(true);

            if (grabLight != null)
                grabLight.enabled = true; // Turn on the light
        }
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        isGrabbed = false;
        if (uiText != null)
            uiText.SetActive(false);

        if (grabLight != null)
            grabLight.enabled = false; // Turn off the light
    }

    private void OnDestroy()
    {
        if (grabInteractable != null)
        {
            grabInteractable.selectEntered.RemoveListener(OnGrab);
            grabInteractable.selectExited.RemoveListener(OnRelease);
        }
    }
}
