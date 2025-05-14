using UnityEngine;

public class RoomSwitcher : MonoBehaviour
{
    public static void SwitchToCanvas(string canvasName)
    {
        // Find all canvases in the scene (including those from additive scenes like the UI overlay)
        Canvas[] canvases = GameObject.FindObjectsByType<Canvas>(FindObjectsInactive.Include, FindObjectsSortMode.None);


        foreach (Canvas canvas in canvases)
        {
            // If it's the one we're switching to, enable it
            if (canvas.name == canvasName)
            {
                canvas.gameObject.SetActive(true);
            }
            // Always keep the overlay canvas on
            else if (canvas.name == "OverlayScene")
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
