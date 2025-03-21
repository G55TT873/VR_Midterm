using UnityEngine;

public class PlaySoundOnImpact : MonoBehaviour
{
    public AudioSource collisionSound; // Assign an AudioSource in the Inspector
    private bool hasCollided = false; // Track if we've already played the sound on this collision

    private void OnCollisionEnter(Collision collision)
    {
        if (!hasCollided) // Only play sound if it hasn't already played
        {
            if (collisionSound != null)
            {
                collisionSound.Play();
            }

            hasCollided = true; // Mark as collided to prevent spam
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        hasCollided = false; // Reset when the object leaves contact with the surface
    }
}
