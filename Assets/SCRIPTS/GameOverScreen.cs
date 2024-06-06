using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private GameObject reiniciar;
    [SerializeField] private GameObject menuGameOver;

    public static GameOverScreen Instance { get; private set; }
    [SerializeField] AudioSource backgroundSound;


    private bool juegoPausado = false;

    public void Start()
    {
        Instance = this;
    }

    public void Perder()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        reiniciar.SetActive(true);
        menuGameOver.SetActive(true);
        backgroundSound.Pause();

    }
    public void Reiniciar()
    {
        if (reiniciar == true)
        {
            juegoPausado = false;
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            backgroundSound.Play();
        }
    }
    public void MenuInicial(string nombre)
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(nombre);

    }
    public void Salir()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        Application.Quit();
    }
}
