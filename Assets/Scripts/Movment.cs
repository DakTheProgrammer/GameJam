﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    private Rigidbody Player;
    public static float Speed = 400f;
    private float SideForce = 1000f;
    private float JumpForce = 10000f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Player.AddForce(Speed * Time.deltaTime, 0, 0); 
        if(Input.GetKey("a"))
        {
            Player.AddForce(0, 0, SideForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            Player.AddForce(0, 0, -SideForce * Time.deltaTime);
        }
        if (Input.GetKey("space") && Player.position.y == 1)
        {
            Player.AddForce(0, JumpForce * Time.deltaTime, 0);
        }
    }
}