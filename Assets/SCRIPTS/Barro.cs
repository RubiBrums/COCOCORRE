using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Barro : MonoBehaviour
{
    public GameObject helen;
    public Animator animacion;
    public AudioClip resbalo;

    void Start()
    {
        animacion = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.ReproducirSonido(resbalo);
            animacion.Play("BarroCharco");
        }
        else
        {
            animacion.Play("Barro");
        }
    }
}
