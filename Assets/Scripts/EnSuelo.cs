using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnSuelo : MonoBehaviour
{
    public static bool enSuelo;

    private void OnTriggerEnter2D(Collider2D other) {
        if(!other.CompareTag("Untagged"))
        enSuelo = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        enSuelo = false;
    }
}
