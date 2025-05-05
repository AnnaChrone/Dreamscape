//Title: Invetory System in Unity 2D using Scriptable Objects
//Author: Sunny Valley Studio
//Date: 19/04/2025
//Code version: -
//Availibity: https://youtube.com/playlist?list=PLcRSafycjWFegXSGBBf4fqIKWkHDw_G8D&si=8OGht_7jCIBl9ZUX

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIController : MonoBehaviour
{
    [SerializeField]
    private UIInventoryPage inventoryUI;

    public int inventorySize = 5; //Number of slots
    private void Start()
    {
        inventoryUI.InitializeInventoryUI(inventorySize); //Initialize size
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) //Press I to access inventory UI
       {
        if (inventoryUI.isActiveAndEnabled == false)
        {
            inventoryUI.Show();
        }
        else
        {
            inventoryUI.Hide();
        }
       }
    }
}
