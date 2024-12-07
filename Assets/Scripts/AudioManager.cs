using UnityEngine;

public class AudioManager
{
    private AudioSource audioSource;

    public AudioManager(AudioSource source)
    {
        audioSource = source;
    }

    public void PlaySound()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
