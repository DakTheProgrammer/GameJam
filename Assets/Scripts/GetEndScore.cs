using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GetEndScore : MonoBehaviour
{
    private Transform play;
    private Text scoreText;
    float num;

    // Start is called before the first frame update
    void Start()
    {
        play = GameObject.Find("Player").GetComponent<Transform>();
        scoreText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        num = play.position.x + 99;
        scoreText.text = "Game Over\nFinal Score: " + num.ToString("0");
    }
}
