using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoDaño : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.CompareTag("Player"))
        {
            other.transform.GetComponent<Respawn>().PlayerDamaged();
        }
    }
}
