using UnityEngine;

public class RoomSwitcher : MonoBehaviour
{
    public static void SwitchToCanvas(string canvasName)
    {
        // Find all canvases in the scene (including those from additive scenes like the UI overlay)
        Canvas[] canvases = GameObject.FindObjectsByType<Canvas>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (Canvas canvas in canvases)
        {
            // Enable the target canvas
            if (canvas.name == canvasName)
            {
                canvas.gameObject.SetActive(true);
            }
            // Always keep OverlayScene and Inventory active
            else if (canvas.name == "OverlayScene" || canvas.name == "Inventory")
            {
                canvas.gameObject.SetActive(true);
            }
            // Disable all others
            else
            {
                canvas.gameObject.SetActive(false);
            }
        }
    }
}

