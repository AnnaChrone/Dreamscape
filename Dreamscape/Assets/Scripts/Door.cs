using UnityEngine;

public class Door : MonoBehaviour
{
    public string targetCanvas;               // Name of the canvas (scene) to switch to
    public string spawnPointInTargetCanvas;   // Name of the spawn point in that canvas

    private static bool isSwitching = false;  // Prevent rapid switching

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isSwitching)
        {
            isSwitching = true;

            // Set player spawn point
            SceneController.SetSpawnPoint(spawnPointInTargetCanvas);

            // Switch room
            RoomSwitcher.SwitchToCanvas(targetCanvas);

            // Start cooldown to prevent instant re-trigger
            Invoke(nameof(ResetSwitching), 0.5f); // Half a second buffer — adjust as needed
        }
    }

    private void ResetSwitching()
    {
        isSwitching = false;
    }
}


