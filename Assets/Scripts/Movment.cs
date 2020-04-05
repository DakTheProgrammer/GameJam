using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    private Rigidbody Player;
    public static float Speed = 200f;
    private float SideForce = 1100f;
    private float JumpForce = 15000f;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Player.position.y > 1)
        {
            Player.AddForce(0, -1000f * Time.deltaTime, 0);
        }
        if (Convert.ToInt32(Player.position.x) % 4 == 0)
        {
            Player.AddForce(Speed * Time.deltaTime, 0, 0);
        }
        if (Player.position.x == -99)
        {
            Player.AddForce(10000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            Player.AddForce(0, 0, SideForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            Player.AddForce(0, 0, -SideForce * Time.deltaTime);
        }
        if (Input.GetKey("space") && Player.position.y <= 1)
        {
            Player.AddForce(100, JumpForce * Time.deltaTime, 0);
        }
    }
}
