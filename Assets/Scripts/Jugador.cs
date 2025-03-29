using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {
    
    public float velocidadSalto;
    public float velocidadCorrer; 
    public SpriteRenderer spriteRenderer;

    private Rigidbody2D cuerpo;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))&& EnSuelo.enSuelo)
        {
            animator.SetBool("salta", true);
            cuerpo.velocity = new Vector2(cuerpo.velocity.x,velocidadSalto); 
        } else if (EnSuelo.enSuelo)
        {
            animator.SetBool("salta", false);
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("corre", true);
            cuerpo.velocity = new Vector2(-velocidadCorrer,cuerpo.velocity.y); 
            spriteRenderer.flipX = true;
        } 
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("corre", true);
            cuerpo.velocity = new Vector2(velocidadCorrer,cuerpo.velocity.y); 
            spriteRenderer.flipX = false;
        } 
        else
        {
            cuerpo.velocity = new Vector2(0,cuerpo.velocity.y);
            animator.SetBool("corre",false);
        }

    }

}
