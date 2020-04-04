using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Movment move;

    private void Start()
    {
        move = gameObject.GetComponent<Movment>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag != "Floor")
        {
            move.enabled = false;
        }
    }
}
