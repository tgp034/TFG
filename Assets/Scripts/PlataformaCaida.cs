using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaCaida : MonoBehaviour
{
    private float fallDelay = 0.05f;
    private float destroyDelay = 2f;
    public Animator animator;
    
    [SerializeField] private Rigidbody2D cuerpoPlataforma;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Caida());
        }
    }

    private IEnumerator Caida()
    {
        yield return new WaitForSeconds(fallDelay);
        cuerpoPlataforma.bodyType = RigidbodyType2D.Dynamic;
        animator.enabled = false;
        Destroy(gameObject,destroyDelay);
    }
}
