using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaDobleSentido : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float startWaitTime;
    public float waitCountdown;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            waitCountdown = startWaitTime;
        }


        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if(waitCountdown <= 0)
            {
                effector.rotationalOffset = 180f;
                waitCountdown = startWaitTime;
            }
        } else
        {
            waitCountdown -= Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
            effector.rotationalOffset = 0;
        }
    }
}
