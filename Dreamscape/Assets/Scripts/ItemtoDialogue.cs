using UnityEngine.SceneManagement;
using UnityEngine;

public class ItemtoDialogue : MonoBehaviour
{
    [Header("Assign this in Inspector")]
    public string itemName;

    [Header("Assign the name of the dialogue scene to load")]
    public string dialogueSceneName;

    public void SelectItem()
    {
        PlayerPrefs.SetString("SelectedItem", itemName);
        PlayerPrefs.Save();

        // Load the dialogue scene additively
        SceneManager.LoadScene(dialogueSceneName, LoadSceneMode.Additive);

        // Optionally unload this scene if you don't need it anymore
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.UnloadSceneAsync(currentScene);
    }
}

