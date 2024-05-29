using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    bool watched;
    private void LateUpdate()
    {
        transform.position = player.position;
        
          //  Cam.transform.rotation = Quaternion.Euler(0, 0, 0);
       
       
    }

  

}
