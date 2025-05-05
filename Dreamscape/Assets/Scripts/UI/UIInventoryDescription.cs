//Title: Invetory System in Unity 2D using Scriptable Objects
//Author: Sunny Valley Studio
//Date: 19/04/2025
//Code version: -
//Availibity: https://youtube.com/playlist?list=PLcRSafycjWFegXSGBBf4fqIKWkHDw_G8D&si=8OGht_7jCIBl9ZUX

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInventoryDescription : MonoBehaviour
{
   [SerializeField]
   private TMP_Text title; //We can now edit this easily in the inspector

   [SerializeField]
   private TMP_Text description;

   public void Awake()
   {
    ResetDescription();
   }

   public void ResetDescription()
   {
    this.title.text = "";
    this.description.text = ""; //Defaualt values
   }

   public void SetDescription(string itemName, string itemDescription)
   {
        this.title.text = itemName;
        this.description.text = itemDescription; //Dedicated values for the title and description.
   }
}
