﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy01 : MonoBehaviour
{
    public float interval;
    

    // Update is called once per frame
    void Update()
    {
        //OnTriggerEnter2D(Collider2D other);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        /*
        if (interval > 0)
        {
            interval -= Time.deltaTime;
        }
        else
        {
            enabled = false;
            Destroy(gameObject);
        }
        */
        Destroy (gameObject, interval);
    }
}
