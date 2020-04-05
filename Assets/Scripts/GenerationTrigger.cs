using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationTrigger : MonoBehaviour
{
    [SerializeField] private List<Transform> Part;

    private Transform MoveMe;


    // Start is called before the first frame update
    void Start()
    {
        MoveMe = GameObject.Find("PasteBlock").GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        Instantiate(Part[Random.Range(0,Part.Count)], MoveMe.position, Quaternion.identity);
        MoveMe.position = new Vector3 (MoveMe.position.x + 200,-0.001f,0);
    }
}
