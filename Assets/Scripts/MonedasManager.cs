using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedasManager : MonoBehaviour
{
    public static bool pasarNivel;

    void Start()
    {
        pasarNivel = false;
    }

    void Update()
    {
        AllCoinsCollected();
    }

    public void AllCoinsCollected()
    {
        if(transform.childCount==0 && !pasarNivel)
        {
            pasarNivel = true;
        }
   }
}
