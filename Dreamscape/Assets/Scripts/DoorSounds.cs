using UnityEngine;

public class DoorSounds : MonoBehaviour
{
    public AudioClip enterSound;
    public AudioClip exitSound;

    public Sprite closedDoorSprite;
    public Sprite openDoorSprite;

    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // assumes the SpriteRenderer is on the same GameObject
    }

    void OnTriggerEnter2D(Collider2D enter)
    {
        if (enter.CompareTag("Player"))
        {
            spriteRenderer.sprite = openDoorSprite;
            if (enterSound != null)
            {
                audioSource.clip = enterSound;
                audioSource.Play();
            }
        }
    }

    void OnTriggerExit2D(Collider2D exit)
    {
        if (exit.CompareTag("Player"))
        {
            spriteRenderer.sprite = closedDoorSprite;
            if (exitSound != null)
            {
                audioSource.clip = exitSound;
                audioSource.Play();
            }
        }
    }
}

