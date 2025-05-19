using UnityEngine;
using TMPro;

public class ScribbleTalking : MonoBehaviour
{
    public GameObject tTextBox;
    public AudioClip ScribbleSound;
    public AudioClip AngrySound;
    public bool Interacted = false;
    private AudioSource audioSource;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject ChoiceTeleport;

    private Inventory inventory;

    void Start()
    {
        tTextBox.SetActive(false);  // Hide text initially
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        // Get the Inventory component from the Player
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Player")
        {
            if (!Interacted)
            {
                ShowText();
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                Interacted = true;
            }
            else if (!AllItemsCollected() && Interacted)
            {
                ShowTextAngry();
            }
            else if (AllItemsCollected())
            {
                tTextBox.GetComponent<TMP_Text>().text = "Step into the darkness, and make your pick...";
                ChoiceTeleport.SetActive(true);
                tTextBox.SetActive(true);
                StartCoroutine(HideTextAfterDelay(3f));
            }
        }
    }

    bool AllItemsCollected()
    {
        // Ensure the inventory has at least 3 slots
        if (inventory.isFull.Length >= 3)
        {
            return inventory.isFull[0] && inventory.isFull[1] && inventory.isFull[2];
        }
        return false;
    }

    void ShowText()
    {
        if (ScribbleSound != null)
            audioSource.PlayOneShot(ScribbleSound);

        tTextBox.SetActive(true);
        StartCoroutine(HideTextAfterDelay(3f));
    }

    void ShowTextAngry()
    {
        if (AngrySound != null)
            audioSource.PlayOneShot(AngrySound);

        tTextBox.GetComponent<TMP_Text>().text = "Oh child, do you not listen? FIND ALL THREE!";
        tTextBox.SetActive(true);
        StartCoroutine(HideTextAfterDelay(3f));
    }

    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        tTextBox.SetActive(false);
    }
}

