
using Unity.VisualScripting;
using UnityEngine;

public class InventoryToggle : MonoBehaviour
{
    public GameObject Inventory_Toggle;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventory_Toggle.SetActive(!Inventory_Toggle.activeSelf); //When a player presses I, The inventory will open or close 
        }    
    }
}
