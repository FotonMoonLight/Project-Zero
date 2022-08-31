using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxLogic : MonoBehaviour
{
    public int _NumTap = 3;
    public GameObject player;
    public GameObject box;
    [Header("Массив предметов")]
    public int[] index;
    public GameObject[] cells;
    public Image[] cell;
    private void Start()
    {
        
    }

    private void Update()
    {
        if(player.GetComponent<PlayerControl>()._PlayerOz == 3)
        {
            gameObject.SetActive(true);
        }
        if(_NumTap == 0)
        {
            RangeItem();
            UpgradeLogic._Pause = false;
            Time.timeScale = 1;
            gameObject.SetActive(false);
            player.GetComponent<PlayerControl>()._PlayerOz = 0;
            _NumTap = 3;
        }
    }
    public void OnChest()
    {
        _NumTap -= 1;
    }
    private void RangeItem()
    {
        for(int i = 0;i <= cells.Length; i++)
        {
            if(cells[i].GetComponent<ItemStat>().IndexItem == 0)
            {
                cells[i].GetComponent<ItemStat>().IndexItem = Random.Range(1, index.Length);
                break;
            }
            else 
            {
                
            }
        }
    }
}
