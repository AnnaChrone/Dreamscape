using UnityEngine;

public class Exit : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Game is exiting...");

        // This will quit the application (only works in builds, not in the Unity editor)
        Application.Quit();

        // If you're in the editor and want to simulate exit:
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void TestButton()
    {
        Debug.Log("Button clicked!");
    }
}
