using UnityEngine;

public class EnableOnPlayerCollision : MonoBehaviour
{
    public GameObject objectToEnable;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the collider belongs to the player
        {
            if (objectToEnable != null)
            {
                objectToEnable.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the player exits the collider
        {
            if (objectToEnable != null)
            {
                objectToEnable.SetActive(false);
            }
        }
    }
}
