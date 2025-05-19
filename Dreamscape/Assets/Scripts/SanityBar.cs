using UnityEngine;
using UnityEngine.UI;

public class SanityBar : MonoBehaviour
{
    public Slider SaneBar;

    private void Start()
    {
        SaneBar.value = LoadOverlay.instance.SanityValue;
        SaneBar.interactable = false;
    }

    public void ModifySanity(float amount)
    {
        LoadOverlay.instance.UpdateSanityValue(SaneBar.value + amount);
        SaneBar.value = LoadOverlay.instance.SanityValue;
    }
}

