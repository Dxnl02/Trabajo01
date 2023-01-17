using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    [SerializeField] float alturaSalto;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Jump") && ComprobarSuelo.estaEnSuelo) || (Input.GetButtonDown("Fire1") && ComprobarSuelo.estaEnSuelo))
        {
            rigidbody.AddForce(Vector2.up * alturaSalto);
            animator.SetBool("IniciarSalto", true);
        }

        if(rigidbody.velocity.y < -0.5f){
            animator.SetBool("Final", true);
            animator.SetBool("IniciarSalto", false);
        }

        if (ComprobarSuelo.estaEnSuelo)
        {
            animator.SetBool("Final", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Enemigo")
        {
            GameManager.Instance.Perder();
        }
    }
}
