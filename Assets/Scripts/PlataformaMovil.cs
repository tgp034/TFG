using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public float speed = 0.5f;
    public Transform[] movespots;
    private int i = 0;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movespots[i].transform.position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, movespots[i].transform.position) < 0.1f)
        {
            if(movespots[i] != movespots[movespots.Length-1])
                i++;
            else
                i = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        other.collider.transform.SetParent(transform);
    }

     private void OnCollisionExit2D(Collision2D other) 
    {
        other.collider.transform.SetParent(null);
    }
}
