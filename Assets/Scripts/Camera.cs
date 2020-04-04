using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform Player;

    private Vector3 offset = new Vector3(-6, 5, 0);

    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + offset;
    }
}
