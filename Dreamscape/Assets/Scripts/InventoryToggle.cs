
using Unity.VisualScripting;
using UnityEngine;

public class InventoryToggle : MonoBehaviour
{
    public GameObject Inventory_Toggle;
    void Start()
    {
        if (Inventory_Toggle == null)
        {
            Debug.LogError($"[InventoryToggle] {gameObject.name} is missing its Inventory_Toggle assignment!");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inventory_Toggle.SetActive(!Inventory_Toggle.activeSelf); //When a player presses I, The inventory will open or close 
        }    
    }
}
