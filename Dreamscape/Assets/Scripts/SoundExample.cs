using JetBrains.Annotations;
using UnityEngine;

public class SoundExample : MonoBehaviour
{

    public AudioClip[] Clips;
    private AudioSource audioSource;
    public ButtonSoundType soundType;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public enum ButtonSoundType
    {
        Cute,
        Scary,
        Scifi
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(ButtonSoundType soundType)
    {
        switch (soundType)
        {
            case ButtonSoundType.Cute:
                audioSource.PlayOneShot(Clips[0]);
                break;

            case ButtonSoundType.Scary:
                audioSource.PlayOneShot(Clips[1]);
                break;

            case ButtonSoundType.Scifi:
                audioSource.PlayOneShot(Clips[2]);
                break;
        }
    }

    public void PlayAssignedSound()
        {
            PlaySound(soundType);
        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
