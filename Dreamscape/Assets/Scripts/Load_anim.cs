using UnityEngine;
using UnityEngine.EventSystems;

public class Button_Anim : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator animator;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hover enter");
        animator.SetBool("Hover", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Hover exit");
        animator.SetBool("Hover", false);
    }
}