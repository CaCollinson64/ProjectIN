using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneWarp : MonoBehaviour
{
    [SerializeField] public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Warp Triggered");
            SceneManager.LoadScene(sceneName);
        }
    }
}