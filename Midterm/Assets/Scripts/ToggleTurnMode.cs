using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleTurnMode : MonoBehaviour
{
    public Toggle turnToggle;
    public ActionBasedContinuousTurnProvider continuousTurnProvider;
    public ActionBasedSnapTurnProvider snapTurnProvider;

    void Start()
    {
        if (turnToggle != null)
            turnToggle.onValueChanged.AddListener(ToggleTurn);
        
        // Ensure default state is set correctly
        ToggleTurn(false);
    }

    void ToggleTurn(bool isSnapTurn)
    {
        if (continuousTurnProvider != null)
            continuousTurnProvider.enabled = !isSnapTurn;

        if (snapTurnProvider != null)
            snapTurnProvider.enabled = isSnapTurn;
    }
}
