using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int _FrameRate = 60;
    void Start()
    {
        
    }

    
    void Update()
    {
            Application.targetFrameRate = _FrameRate;
    }
}
