using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scarecrow : MonoBehaviour
{
    [SerializeField] private float hp;

    public int hitCount = 0;
    private Animator scarecrow;
    public GameObject espantapajarosD;
    public GameObject haySkin;
    public AudioClip golpe;
    public AudioClip ouch;


    void Start()
    {
        scarecrow = GetComponent<Animator>();
    }
 /*   void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hitCount++;

            if (hitCount >= 1)
            {
                AudioManager.Instance.ReproducirSonido(golpe);
                scarecrow.SetTrigger("Hit1");
            }
            if (hitCount >= 2)
            {
                AudioManager.Instance.ReproducirSonido(golpe);
                scarecrow.SetTrigger("Hit2");
            }
            if (hitCount >= 3)
            {
                AudioManager.Instance.ReproducirSonido(golpe);
                scarecrow.SetTrigger("Hit3");
                DestruyeScarecrow();
            }
        }
    }*/

    public void RecibirDaño(float daño)
    {
        hp -= daño;

        if (hp == 7.5f)
        {
            AudioManager.Instance.ReproducirSonido(golpe);
            scarecrow.SetTrigger("Hit1");
        }

        if (hp == 5f)
        {
            AudioManager.Instance.ReproducirSonido(golpe);
            scarecrow.SetTrigger("Hit2");
        }

        if (hp == 2.5f)
        {
            AudioManager.Instance.ReproducirSonido(golpe);
            scarecrow.SetTrigger("Hit3");
        }

        if (hp <= 0f)
        {
            DestruyeScarecrow();
        }
    }

    void DestruyeScarecrow()
    {
        scarecrow.SetTrigger("Hit3");
        Invoke("DestruirEspantapajaros", 0f);
    }
    void DestruirEspantapajaros()
    {
        AudioManager.Instance.ReproducirSonido(ouch);
        scarecrow.SetTrigger("Break");
        Invoke("Explosion", 0.5f);

    }
    void Explosion()
    {
        scarecrow.Play("Explosion");
        Death();
    }
    void Death()
    {
        Destroy(gameObject);
        haySkin.SetActive(true);
        espantapajarosD.SetActive(true);
        GameManager.Instance.PerderVida();
    }
}
