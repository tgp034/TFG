using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarNivel : MonoBehaviour
{
    public GameObject transition;

    void Update()
    {
        if(MonedasManager.pasarNivel)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    } 

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") && MonedasManager.pasarNivel)
        {
            transition.SetActive(true);
            if(SceneManager.GetActiveScene().buildIndex < 4)
                Invoke("SiguienteNivel",1);
            else
                SceneManager.LoadScene(0);
        }
    }

    void SiguienteNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
