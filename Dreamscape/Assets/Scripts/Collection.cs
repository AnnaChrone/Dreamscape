using UnityEngine;
using TMPro;

public class Collection : MonoBehaviour
{
    public GameObject tTextBox;
    public AudioClip collectSound; // Drag your sound here in the Inspector

    private Collider2D col;
    private SpriteRenderer sr;
    private AudioSource audioSource;

    void Start()
    {
        tTextBox.SetActive(false);  // Hide text initially
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();

        // Create or use existing AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Player")
        {
            ShowText(); // Show the label and play sound
        }
    }

    void ShowText()
    {
        if (collectSound != null)
            audioSource.PlayOneShot(collectSound);

        tTextBox.SetActive(true);
        StartCoroutine(HideTextAfterDelay(2f));
    }

    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        if (col != null) col.enabled = false;
        if (sr != null) sr.enabled = false;

        yield return new WaitForSeconds(delay);
        tTextBox.SetActive(false);
        Destroy(gameObject); // Destroy item after sound and text
    }
}

