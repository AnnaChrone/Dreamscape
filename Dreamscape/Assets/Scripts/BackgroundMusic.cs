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

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string sceneName = scene.name;

        // Basic pattern matching: any scene starting with "Topdown" uses the topdown song
        if (sceneName.StartsWith("Topdown"))
        {
            PlayMusic(TDMusic);
        }
        else if (sceneName.StartsWith("Dialogue"))
        {
            PlayMusic(DMusic);
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
    }
}
