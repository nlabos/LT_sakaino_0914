﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickContoroller : MonoBehaviour
{
    public Transform player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Controller(Collision colision)
    {
        if(colision.gameObject.tag == "stick")
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, speed, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -speed, 0);
            }
            if (Input.GetKey(KeyCode.J))
            {
                player.Rotate(0, 10f, 0);
            }
            if (Input.GetKey(KeyCode.L))
            {
                player.Rotate(0, -10f, 0);
            }
        }
    }
    void Update()
    {
        
    }
}