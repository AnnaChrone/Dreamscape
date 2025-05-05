using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;  // For coroutines


public class FriendshipBar : MonoBehaviour
{
    public Slider FriendBar;
    private CanvasGroup canvasGroup;  // To control fading

    public void IncreaseFriendship()
    {
        LoadOverlay.instance.UpdateFriendValue(FriendBar.value + 2);
        FriendBar.value = LoadOverlay.instance.FriendValue;
        StartCoroutine(Fade());
        
    }

    public void DecreaseFriendship()
    {
        LoadOverlay.instance.UpdateFriendValue(FriendBar.value - 2);
        FriendBar.value = LoadOverlay.instance.FriendValue;
        StartCoroutine(Fade());
    }

    // Coroutine to fade in and out the slider
    private IEnumerator Fade()
    {
        // Fade in: Set alpha from 0 to 1 over time
        yield return StartCoroutine(FadingAlpha(1f, 1f));  // 1f is the fade duration, and is fading in to visible

        // Wait for a brief moment before fading out
        yield return new WaitForSeconds(3f);  // how long the bar will stay visible

        // Fade out: Set alpha from 1 to 0 over time
        yield return StartCoroutine(FadingAlpha(0f, 1f));  // 1f is the fade duration, and is fading to 0 (invisible)
    }

    // Coroutine to change the alpha value smoothly
    private IEnumerator FadingAlpha(float targetAlpha, float duration) //gradually changes opacity of the slider
    {
        float startAlpha = canvasGroup.alpha; //stores what the aplha of the canvas group currently
        float TimeElapsed = 0f;

        while (TimeElapsed < duration)
        {
            // Gradually change the alpha value
            canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, TimeElapsed / duration); //smoothly transitions between the two alpha values based on a percentage (TimeElapsed/duration)
            TimeElapsed += Time.deltaTime; //stores how much real time has elapsed
            yield return null;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the CanvasGroup component from the Slider's parent
        canvasGroup = FriendBar.GetComponent<CanvasGroup>(); //getting the canvasgroup component so fading can work
        FriendBar.value = LoadOverlay.instance.FriendValue;

        canvasGroup.alpha = 0f; //sets slider to be invisible on start
        canvasGroup.interactable = false; //stops user from being able to manually change the slider
        canvasGroup.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
