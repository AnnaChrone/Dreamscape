using UnityEngine;

public class IncreaseSanityButton : MonoBehaviour
{
    public void IncreaseSanityBy10()
    {
        if (LoadOverlay.instance != null)
        {
            LoadOverlay.instance.sanityBar.ModifySanity(-10f);
        }
        else
        {
            Debug.LogWarning("LoadOverlay instance not found!");
        }
    }
}

