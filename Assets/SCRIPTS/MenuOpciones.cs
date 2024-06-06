using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixerMusica;
    [SerializeField] private AudioMixer audioMixerSFX;

    public void PantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void CambiarVolumenMusica(float volumen)
    {
        audioMixerMusica.SetFloat("VolumenMusica", volumen);
    }
    public void CambiarVolumenSFX(float volumen)
    {
        audioMixerSFX.SetFloat("VolumenSFX", volumen);
    }
}
