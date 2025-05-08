using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string targetScene;               // Name of the scene to load when walked through door
    public string spawnPointInTargetScene;   // Name of the spawn point to appear at on the other side
    public string OverlayName = "OverlayScene"; // Name of your overlay scene

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneController.SetSpawnPoint(spawnPointInTargetScene);
            SceneManager.LoadScene(targetScene);
            SceneManager.LoadScene(OverlayName, LoadSceneMode.Additive); // Re-adds overlay
        }
    }
}
