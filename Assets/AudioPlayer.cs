using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audioClip;
    public bool loop = true;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.loop = loop;
        audioSource.Play();
    }
}

