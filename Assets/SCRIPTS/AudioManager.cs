using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public static AudioManager Instance { get; private set; }


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log(" Más de 1 AudioManager");
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Instance = this;

    }

    public void ReproducirSonido(AudioClip audio)
    {
        audioSource.PlayOneShot(audio);
    }
    public void StopSonido()
    {
        audioSource.Pause();
    }
    public void ResumeSonido()
    {
        audioSource.Play();
    }
}
