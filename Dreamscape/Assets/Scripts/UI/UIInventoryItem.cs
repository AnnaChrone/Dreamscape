//Title: Invetory System in Unity 2D using Scriptable Objects
//Author: Sunny Valley Studio
//Date: 19/04/2025
//Code version: -
//Availibity: https://youtube.com/playlist?list=PLcRSafycjWFegXSGBBf4fqIKWkHDw_G8D&si=8OGht_7jCIBl9ZUX

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI; //Need this to swap images to show empty and full slots


public class UIInventoryItem : MonoBehaviour
{
    [SerializeField] //Allows us to edit this in thr inspector
    private Image itemImage;

    public event Action<UIInventoryItem> OnItemClicked; //Click the item for description

    private bool empty = true;
    public void Awake()
    {
        ResetData(); //No data appears when program is first opened
    }

   public void ResetData()
   {
    this.itemImage.gameObject.SetActive(false); //Makes slot empty
    empty = true;
   }

    public void SetData(Sprite sprite)
    {
        this.itemImage.gameObject.SetActive(true);
        this.itemImage.sprite = sprite; //Add item to slot, we dont have any sprites at the moment
        empty = false;
    }

    public void OnItemClick(BaseEventData data)
    {   
        PointerEventData pointerData = (PointerEventData)data;
        if (pointerData.button == PointerEventData.InputButton.Left)
        {
            OnItemClicked?.Invoke(this); //If the left mouse button is clicked, this event is triggered
        }
    }
}
