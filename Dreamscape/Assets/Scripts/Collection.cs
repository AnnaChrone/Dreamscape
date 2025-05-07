using UnityEngine;
using TMPro;

public class Collection : MonoBehaviour
{
    public GameObject tTextBox;
    private Collider2D col;
    private SpriteRenderer sr;

    void Start()
    {
        tTextBox.SetActive(false);  // Ensure the text is hidden at the start
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Player")
        {
            ShowText(); // Show the label
        }
    }

    void ShowText()
    {
        tTextBox.SetActive(true);
        StartCoroutine(HideTextAfterDelay(2f));
    }

    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        // Visually and physically disable the object, but not the script
        if (col != null) col.enabled = false;
        if (sr != null) sr.enabled = false;

        yield return new WaitForSeconds(delay);
        tTextBox.SetActive(false);
         Destroy(gameObject); //Destroys game object because we instantiated it
    }
}

