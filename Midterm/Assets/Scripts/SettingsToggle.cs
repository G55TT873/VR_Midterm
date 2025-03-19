using UnityEngine;
using UnityEngine.InputSystem;

public class SettingsToggle : MonoBehaviour
{
    public InputActionReference toggleAction; // Input action reference
    public GameObject settings; // The settings panel

    private void OnEnable()
    {
        if (toggleAction != null)
            toggleAction.action.performed += ToggleSettings;
    }

    private void OnDisable()
    {
        if (toggleAction != null)
            toggleAction.action.performed -= ToggleSettings;
    }

    private void ToggleSettings(InputAction.CallbackContext context)
    {
        if (settings != null)
            settings.SetActive(!settings.activeSelf);
    }
}
