using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotenciadorVelocidad : MonoBehaviour
{
    public GameObject velocidadEscenario;
    public GameObject velocidadBG;

    public ScrollingTilemap velocidad1;
    public ScrollingTilemap velocidad2;


    public float newScrollSpeed = 5f;


    void OnTriggerEnter2D(Collider2D colision)
    {
        velocidad1.scrollSpeed = newScrollSpeed;
        velocidad2.scrollSpeed = newScrollSpeed;
        Destroy(this.gameObject);
    }
}
