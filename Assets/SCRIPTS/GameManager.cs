using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int PuntosTotales { get; private set; }
    public HUD hud;

    private int vidas = 2;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Mas de 1 GameManager en la escena");
        }
    }
    public void SumarPuntos(int puntosPorSumar)
    {
        PuntosTotales += puntosPorSumar;
        hud.ActualizarPuntos(PuntosTotales);
    }
    public void PerderVida()
    {
        vidas -= 1;
        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
        hud.DesactivarVida(vidas);
    }

    public bool RecuperarVida()
    {
        if (vidas == 2)
        {
            return false;
        }
        hud.ActivarVida(vidas);
        vidas += 1;
        return true;
    }

    public void GameOver()
    {
        GameOverScreen.Instance.Perder();
    }


}
