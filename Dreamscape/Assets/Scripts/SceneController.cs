using UnityEngine;

public class SceneController : MonoBehaviour
{
    public static string spawnPointName;
    private void Awake()
    {
        // Only one instance should persist
        var existingControllers = FindObjectsByType<SceneController>(FindObjectsSortMode.None);
        if (existingControllers.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public static void SetSpawnPoint(string name)
    {
        spawnPointName = name;
    }
}
