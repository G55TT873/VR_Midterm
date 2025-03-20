using UnityEngine;

public class CharacterTalkAnimation : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource1; // First AudioSource
    [SerializeField] private AudioSource audioSource2; // Second AudioSource
    [SerializeField] private Animator animator; // Animator component

    private void Update()
    {
        if (animator == null)
        {
            Debug.LogWarning("Animator not assigned in CharacterTalkAnimation.");
            return;
        }

        bool isTalking = (audioSource1 != null && audioSource1.isPlaying && audioSource1.volume > 0.01f) ||
                         (audioSource2 != null && audioSource2.isPlaying && audioSource2.volume > 0.01f);

        animator.SetBool("talking", isTalking);
        animator.SetBool("Idle", !isTalking);
    }
}
