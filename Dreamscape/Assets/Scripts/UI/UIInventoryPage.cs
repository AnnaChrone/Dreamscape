//Title: Invetory System in Unity 2D using Scriptable Objects
//Author: Sunny Valley Studio
//Date: 19/04/2025
//Code version: -
//Availibity: https://youtube.com/playlist?list=PLcRSafycjWFegXSGBBf4fqIKWkHDw_G8D&si=8OGht_7jCIBl9ZUX

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class UIInventoryPage : MonoBehaviour
{
  [SerializeField]
  private UIInventoryItem itemPrefab; //A custom class, can be game object

  [SerializeField]
  private RectTransform contentPanel;

  [SerializeField]
  private UIInventoryDescription itemDescription;

  List<UIInventoryItem> listofUIItems = new List<UIInventoryItem>(); //Store index of UI items, can use an array as well

  public event Action<int> OnDescriptionRequested;
    public Sprite image;
    public string title, description; //This is to give the Text Mesh values 

    private void Awake()
    {
        Hide();
        itemDescription.ResetDescription(); //Hides description when program is opened
    }

    public void InitializeInventoryUI(int inventorysize)
  {
    for (int i = 0; i < inventorysize; i++)
    {
    UIInventoryItem uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
    uiItem.transform.SetParent(contentPanel);
    listofUIItems.Add(uiItem); //Creates list of number of items in inventory
    uiItem.OnItemClicked += ShowItemActions;
    }
  }

  public void ShowItemActions(UIInventoryItem obj)
  {
    itemDescription.SetDescription(title, description); //Fills Text Mesh
  }
  public void Show()
  {
    gameObject.SetActive(true); //Makes inventory visible
    itemDescription.ResetDescription();

    listofUIItems[0].SetData(image);
  }

  public void Hide()
  {
    gameObject.SetActive(false); //Makes inventory invisible
  }
}
