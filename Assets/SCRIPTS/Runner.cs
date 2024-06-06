using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public float fuerzaSalto = 12.5f;
    private Rigidbody2D rigidBody;
    private BoxCollider2D boxColision;
    public LayerMask capaPiso;

    public AudioClip sonidoEspuela;
    public AudioClip sonidoSalto;
    public AudioClip sonidoHurt;
    public AudioClip sonidoStartled;

    private Animator animator;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        boxColision = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        jumpProcess();
    }

    private void FixedUpdate()
    {
        animator.SetBool("InGround", EstaEnPiso());

    }

    bool EstaEnPiso()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxColision.bounds.center, new Vector2(boxColision.bounds.size.x, boxColision.bounds.size.y), 0f, Vector2.down, 0.5f, capaPiso);
        return raycastHit.collider != null;
    }
    void jumpProcess()
    {
        if (Input.GetKeyDown(KeyCode.W) && EstaEnPiso())
        {
            animator.Play("RunJump");
            AudioManager.Instance.ReproducirSonido(sonidoSalto);
            rigidBody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }

    }
}
