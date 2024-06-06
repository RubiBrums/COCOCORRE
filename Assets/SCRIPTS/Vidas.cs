using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.CompareTag("Player"))
        {
            bool vidaRecuperada = GameManager.Instance.RecuperarVida();
            if (vidaRecuperada)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

