using UnityEngine;
using System.Collections;

public class Collection : MonoBehaviour
{
    public string itemID;                    // Unique ID for this item
    public GameObject tTextBox;              // UI text object (e.g., "Item Collected")
    public AudioClip collectSound;           // Sound to play on pickup

    private Collider2D col;
    private SpriteRenderer sr;
    private AudioSource audioSource;

    void Start()
    {
        // If already collected, destroy self
        if (CollectedItemsManager.Instance != null &&
            CollectedItemsManager.Instance.IsCollected(itemID))
        {
            Destroy(gameObject);
            return;
        }

        if (tTextBox != null)
            tTextBox.SetActive(false);  // Hide text initially

        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();

        // Create or use AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Player"))
        {
            ShowText();
        }
    }

    void ShowText()
    {
        if (CollectedItemsManager.Instance != null && collectSound != null)
        {
            CollectedItemsManager.Instance.PlayCollectSound(collectSound);
        }


        if (tTextBox != null)
        {
            tTextBox.SetActive(true);
            CollectedItemsManager.Instance.StartCoroutine(
        CollectedItemsManager.Instance.HideTextExternally(tTextBox, gameObject, 2f));
        }

        // Disable item visuals
        if (col != null) col.enabled = false;
        if (sr != null) sr.enabled = false;

        ParticleSystemRenderer psr = GetComponentInChildren<ParticleSystemRenderer>();
        if (psr != null) psr.enabled = false;
    }

    IEnumerator HideTextAfterDelay(float delay)
    {
        Debug.Log("Coroutine started for delay: " + delay);

        float elapsed = 0f;
        while (elapsed < delay)
        {
            elapsed += Time.deltaTime;
            Debug.Log($"Coroutine running... elapsed = {elapsed:F2}");
            yield return null;
        }

        Debug.Log("Coroutine finished. Hiding text.");

        if (tTextBox != null)
        {
            Debug.Log("Deactivating tTextBox: " + tTextBox.name);
            tTextBox.SetActive(false);
        }
        else
        {
            Debug.LogWarning("tTextBox was null during coroutine end!");
        }

        Debug.Log("Destroying collected item object.");
        Destroy(gameObject);
    }

}







