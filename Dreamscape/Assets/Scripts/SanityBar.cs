using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class SanityBar : MonoBehaviour
{
    public Slider SaneBar;

      public void IncreaseSanity(float amount)
     {
        LoadOverlay.instance.UpdateSanityValue(SaneBar.value + 10);
        SaneBar.value = LoadOverlay.instance.SanityValue;
      }
    

    public void DecreaseSanity(float amount)
    {
        LoadOverlay.instance.UpdateSanityValue(SaneBar.value - 10);
        SaneBar.value = LoadOverlay.instance.SanityValue;

    }

 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SaneBar.value = LoadOverlay.instance.SanityValue;
        SaneBar.interactable = false; //stops user from being able to manually change the slider

    }

    // Update is called once per frame
    void Update()
    {

    }
}
