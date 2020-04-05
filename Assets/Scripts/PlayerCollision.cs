using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Movment move;
    public GameObject GameOverUI;
    private Rigidbody rb;

    private void Start()
    {
        move = gameObject.GetComponent<Movment>();
        rb = GameObject.Find("Player").GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag != "Floor")
        {
            move.enabled = false;
            GameOverUI.SetActive(true);
            rb.AddForce(0, -100, 0);
            rb.AddForce(0, -100, 0);
            rb.AddForce(0, -100, 0);
            rb.mass = 1000;

        }
    }
}
