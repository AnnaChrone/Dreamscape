using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip TDMusic;
    public AudioClip DMusic;

    private AudioSource audioSource;
    private static BackgroundMusic instance;

    void Awake()
    {
        // Singleton pattern to avoid duplicates
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        // Set up AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.playOnAwake = false;

        //listening for scene changes
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void Start()
    {
        // Ensure music starts even in the first loaded scene
        string currentScene = SceneManager.GetActiveScene().name;
        HandleSceneMusic(currentScene);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        HandleSceneMusic(scene.name);
    }

    void HandleSceneMusic(string sceneName)
    {
        Debug.Log("Handling music for scene: " + sceneName);

        if (sceneName.Contains("Topdown"))
        {
            PlayMusic(TDMusic);
        }
        else if (sceneName.Contains("Dialogue"))
        {
            PlayMusic(DMusic);
        }
        else
        {
            Debug.Log("No music assigned for scene: " + sceneName);
        }
    }

    void PlayMusic(AudioClip clip)
    {
        if (clip == null) return;

        // Only switch music if it's different
        if (audioSource.clip == clip && audioSource.isPlaying)
            return;

        audioSource.clip = clip;
        audioSource.Play();
        Debug.Log("Playing music: " + clip.name);
    }
}
