using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Collection : MonoBehaviour
{
    public GameObject tTextBox;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Player")
        {
            
            ShowText(); // Show the label
            gameObject.SetActive(false); // Disables the object
        }
    }

    void ShowText()
    {
        tTextBox.SetActive(true);
        StartCoroutine(HideTextAfterDelay(3f));  // Hide after 3 seconds
    }

    System.Collections.IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        tTextBox.SetActive(false);
    }

    void Start()
    {
        tTextBox.SetActive(false);  // Ensure the text is hidden at the start
    }
}

