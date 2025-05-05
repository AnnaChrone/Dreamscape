using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public string sceneLoad;
    public string OverlayName = "OverlayScene"; // Name of your overlay scene


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // if player collides with the object, then scene loads
        {
            Debug.Log("Player entered trigger — loading scene: " + sceneLoad);
            SwitchToSceneWithOverlay();
        }
    }

    public void SwitchFromDialogue()
    {
        Debug.Log("Switching from dialogue → loading scene: " + sceneLoad);
        SwitchToSceneWithOverlay();
    }

    private void SwitchToSceneWithOverlay()
    {
        SceneManager.LoadScene(sceneLoad); // Loads the main scene
        SceneManager.LoadScene(OverlayName, LoadSceneMode.Additive); // Re-adds overlay
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
