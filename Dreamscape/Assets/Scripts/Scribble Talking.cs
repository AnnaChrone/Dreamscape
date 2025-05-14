using UnityEngine;
using TMPro;

public class ScribbleTalking : MonoBehaviour
{
    public GameObject tTextBox;
    public AudioClip ScribbleSound;
    public AudioClip AngrySound;
    public bool Interacted = false;
    private AudioSource audioSource;
    public int ItemsCollected = 0;


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
          
            if (Interacted == false)
            {
                ShowText(); // Show the label and play sound
                item1.SetActive(true);
                item2.SetActive(true);
                item3.SetActive(true);
                Interacted = true;
                print(Interacted);
            }
            else if ((ItemsCollected != 3) && (Interacted==true))
            {
                ShowTextAngry();
            }
            
        }
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

        tTextBox.GetComponent<TMP_Text>().text = "YOU HAVEN'T FOUND ALL THREE, DON'T ANGER ME!";
        tTextBox.SetActive(true);
        StartCoroutine(HideTextAfterDelay(3f));
    }

    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        tTextBox.SetActive(false);
    }
}

