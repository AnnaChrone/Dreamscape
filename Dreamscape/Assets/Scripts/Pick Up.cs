using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itembutton; //Each item has a "button" for interaction

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //Player has the Tag "Player"
    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)   
            {
                if (inventory.isFull[i] == false)
                {
                    //Item is added to inventory in location of inventory slot
                    inventory.isFull[i] = true;
                    Instantiate(itembutton, inventory.slots[i].transform, false);
                    Destroy(gameObject); //Destroys game object because we instantiated it
                    break;
                }   
            }
        }
    }
}
