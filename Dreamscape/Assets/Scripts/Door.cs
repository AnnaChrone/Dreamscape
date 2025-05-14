using UnityEngine;

public class Door : MonoBehaviour
{
    public string targetCanvas;               // Name of the canvas (same as the former scene)
    public string spawnPointInTargetCanvas;   // Where to place the player in the target canvas

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Set spawn point for the player
            SceneController.SetSpawnPoint(spawnPointInTargetCanvas);

            // Switch canvases
            RoomSwitcher.SwitchToCanvas(targetCanvas);
        }
    }
}

