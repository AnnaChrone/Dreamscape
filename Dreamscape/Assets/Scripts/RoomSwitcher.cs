using UnityEngine;

public class RoomSwitcher : MonoBehaviour
{
    public static void SwitchToCanvas(string canvasName)
    {
        Canvas[] allCanvases = GameObject.FindObjectsOfType<Canvas>(true); // Include inactive
        foreach (Canvas canvas in allCanvases)
        {
            if (canvas.name == canvasName)
                canvas.gameObject.SetActive(true);
            else if (canvas.name != "OverlayCanvas") // Keep overlay active
                canvas.gameObject.SetActive(false);
        }

        // Optional: handle room-specific audio
        foreach (AudioSource audio in GameObject.FindObjectsOfType<AudioSource>(true))
        {
            Canvas parentCanvas = audio.GetComponentInParent<Canvas>();
            if (parentCanvas != null)
                audio.mute = (parentCanvas.name != canvasName);
        }
    }
}
