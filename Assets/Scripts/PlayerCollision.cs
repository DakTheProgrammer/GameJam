using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Movment move;
    public GameObject GameOverUI;

    private void Start()
    {
        move = gameObject.GetComponent<Movment>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag != "Floor")
        {
            move.enabled = false;
            GameOverUI.SetActive(true);
        }
    }
}
