using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSpecificSceneOnTrigger : MonoBehaviour
{
    public int SceneSelect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneSelect);
        }
    }
}
