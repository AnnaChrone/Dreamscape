using UnityEngine;
using TMPro;

public class ScribbleTalking : MonoBehaviour
{
    public GameObject tTextBox;
    public AudioClip ScribbleSound; // Drag your sound here in the Inspector
    public bool Interacted = false;
    private AudioSource audioSource;


    public GameObject item1;
    public GameObject item2; 
    public GameObject item3; 

    void Start()
    {
        tTextBox.SetActive(false);  // Hide text initially

        // Create or use existing AudioSource
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Player" )
        {
            ShowText(); // Show the label and play sound
            // Unhide all items
            if (Interacted == false)
            item1.SetActive(true);
            item2.SetActive(true);
            item3.SetActive(true);
            Interacted = true;
            print(Interacted);
        }
    }

    void ShowText()
    {
        if (ScribbleSound != null)
            audioSource.PlayOneShot(ScribbleSound);

        tTextBox.SetActive(true);
        StartCoroutine(HideTextAfterDelay(3f));
    }

    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        tTextBox.SetActive(false);
    }
}

