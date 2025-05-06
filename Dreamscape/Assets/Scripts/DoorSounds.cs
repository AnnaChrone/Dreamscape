using UnityEngine;

public class DoorSounds : MonoBehaviour
{
    public AudioClip enterSound;
    public AudioClip exitSound;
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D enter)
    {
        if (enter.CompareTag("Player"))
        {
            audioSource.clip = enterSound;
            audioSource.Play();
        }
    }

    void OnTriggerExit2D(Collider2D exit)
    {
        if (exit.CompareTag("Player"))
        {
            audioSource.clip = exitSound;
            audioSource.Play();
        }
    }
}
