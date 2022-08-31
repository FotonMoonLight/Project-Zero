using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLogic : MonoBehaviour
{
    private int _NumTap = 3;
    public GameObject player;
    [Header ("Массив предметов")]
    public GameObject[] items;
    private void Start()
    {
        
    }

    private void Update()
    {
        if(player.GetComponent<PlayerControl>()._PlayerOz == 3)
        {
            gameObject.SetActive(true);
        }
        if(_NumTap== 0)
        {

        }
    }
    public void OnChest()
    {
        _NumTap -= 1;
    }
}
