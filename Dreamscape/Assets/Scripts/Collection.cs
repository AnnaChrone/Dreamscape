using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Collection : MonoBehaviour
{
    public GameObject tTextBox;
    public GameObject tLabel;

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.name == "Player")
        {
            gameObject.SetActive(false); //Disables the object
            
            ShowText();//Confirms collection
        }
    }

    //When an item gets collected it will appear in the inventory UI. This will be done with our sprites.

    void ShowText()
    {
        tTextBox.SetActive(true);  // Enable the text object
        tLabel.SetActive(false);
    }

    void Start()
    {
        tTextBox.SetActive(false);  // Ensure the text is hidden at the start
    }
}


