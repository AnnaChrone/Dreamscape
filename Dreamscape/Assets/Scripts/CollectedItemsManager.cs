using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CollectedItemsManager : MonoBehaviour
{
    public static CollectedItemsManager Instance;

    private HashSet<string> collectedItems = new HashSet<string>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Debug.Log("CollectedItemsManager initialized. Instance ID: " + GetInstanceID());
    }

    public void MarkCollected(string id)
    {
        if (!collectedItems.Contains(id))
            collectedItems.Add(id);
    }

    public bool IsCollected(string id)
    {
        return collectedItems.Contains(id);
    }

    public IEnumerator HideTextExternally(GameObject textBox, GameObject item, float delay)
    {
        Debug.Log("External coroutine started.");

        float elapsed = 0f;
        while (elapsed < delay)
        {
            elapsed += Time.deltaTime;
            Debug.Log($"[Manager] Coroutine running... elapsed = {elapsed:F2}");
            yield return null;
        }

        if (textBox != null)
        {
            Debug.Log("[Manager] Hiding text box: " + textBox.name);
            textBox.SetActive(false);
        }

        if (item != null)
        {
            Debug.Log("[Manager] Destroying item: " + item.name);
            Destroy(item);
        }
    }

    public void PlayCollectSound(AudioClip clip)
    {
        if (clip == null) return;

        GameObject soundObject = new GameObject("TempAudio");
        AudioSource source = soundObject.AddComponent<AudioSource>();
        source.clip = clip;
        source.playOnAwake = false;
        source.volume = 1f;
        source.spatialBlend = 0f; // 2D sound
        source.Play();

        Destroy(soundObject, clip.length + 0.1f); // Clean up
    }

}
