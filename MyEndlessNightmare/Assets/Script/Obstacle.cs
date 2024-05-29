using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    private void Start()
    {
        player = FindObjectOfType<PLayerController>().gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Detect");
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PLayerController>().moveSpeed -=1;
        
    }


}
