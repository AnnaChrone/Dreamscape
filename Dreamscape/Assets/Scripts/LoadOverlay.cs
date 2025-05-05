using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOverlay : MonoBehaviour
{
    public string OverlayName = "OverlayScene"; // Name of your overlay scene
    public static LoadOverlay instance;

    public float SanityValue = 100f;  // The value on the bar, adjust type as necessary
    public float FriendValue = 0f;

    void Awake()
    {
        // Ensure there's only one instance of this GameObject across all scenes
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep this object alive across scenes
            Debug.Log("Attempting to load overlay scene: " + OverlayName);

            // Ensure that the OverlayScene is loaded only once
            if (!SceneManager.GetSceneByName(OverlayName).isLoaded)
            {
                SceneManager.LoadScene(OverlayName, LoadSceneMode.Additive);
                Debug.Log("OverlayScene loaded additively!");
            }
        }
        else
        {
            Destroy(gameObject); // Destroy this GameObject if there's already an instance of the overlay loader
        }
    }

    public void UpdateSanityValue(float newValue)
    {
        SanityValue = newValue;
    }

    public void UpdateFriendValue(float newValue)
    {
        FriendValue = newValue;
    }

    void Start()
    {
        Debug.Log("OverlayScene loaded!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
