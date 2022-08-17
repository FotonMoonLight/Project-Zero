using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        Vector3 cameraPos = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        transform.position = cameraPos;
    }
}
