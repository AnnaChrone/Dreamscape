using UnityEngine;

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
        if (collectSound != null && audioSource != null && audioSource.enabled)
        {
            audioSource.PlayOneShot(collectSound);
        }

        if (tTextBox != null)
        {
            tTextBox.SetActive(true);
            StartCoroutine(HideTextAfterDelay(2f));
        }

        // Immediately mark the item as collected
        if (CollectedItemsManager.Instance != null)
            CollectedItemsManager.Instance.MarkCollected(itemID);

        // Hide the item's sprite and collider right away
        if (col != null) col.enabled = false;
        if (sr != null) sr.enabled = false;

        ParticleSystemRenderer psr = GetComponentInChildren<ParticleSystemRenderer>();
        if (psr != null) psr.enabled = false;
    }

    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (tTextBox != null)
            tTextBox.SetActive(false);

        Destroy(gameObject); // Fully remove the item
    }
}






