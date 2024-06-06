using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterArea : MonoBehaviour
{

    public Animator Fades;
    private void Start()
    {
        Fades = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Fades.SetTrigger("FADEIN");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Fades.SetTrigger("FADEOUT");
        }
    }
}
