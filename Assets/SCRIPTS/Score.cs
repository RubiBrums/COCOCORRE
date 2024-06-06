using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int valor = 1;
    public AudioClip sonidoScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.Instance.ReproducirSonido(sonidoScore);
            GameManager.Instance.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }

}
