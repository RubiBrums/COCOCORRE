using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HUD : MonoBehaviour
{
    public TextMeshProUGUI puntaje;
    public GameObject[] vidasVacias;
    public GameObject[] vidas;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        puntaje.text = GameManager.Instance.PuntosTotales.ToString();
    }
    public void ActualizarPuntos(int puntosTotales)
    {
        puntaje.text = puntosTotales.ToString();
    }
    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }
    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
