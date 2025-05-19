using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FriendshipBar : MonoBehaviour
{
    public Slider FriendBar;
    private CanvasGroup canvasGroup;

    private void Start()
    {
        canvasGroup = FriendBar.GetComponent<CanvasGroup>();
        FriendBar.value = LoadOverlay.instance.FriendValue;

        canvasGroup.alpha = 0f;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }

    public void ModifyFriendship(int amount)
    {
        LoadOverlay.instance.UpdateFriendValue(FriendBar.value + amount);
        FriendBar.value = LoadOverlay.instance.FriendValue;
        StartCoroutine(Fade());
    }

    private IEnumerator Fade()
    {
        yield return StartCoroutine(FadingAlpha(1f, 1f));
        yield return new WaitForSeconds(3f);
        yield return StartCoroutine(FadingAlpha(0f, 1f));
    }

    private IEnumerator FadingAlpha(float targetAlpha, float duration)
    {
        float startAlpha = canvasGroup.alpha;
        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, timeElapsed / duration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        canvasGroup.alpha = targetAlpha;
    }
}
