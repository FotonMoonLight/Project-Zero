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
            SortItem();
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
    private void SortItem()
    {
        int maxNum = cells[0].GetComponent<ItemStat>().IndexItem;
       for(int i = 0; i < cells.Length; i++)
        {
            if(cells[i].GetComponent<ItemStat>().IndexItem > maxNum)
            {
                maxNum = cells[i].GetComponent<ItemStat>().IndexItem;
            }
        }
       for(int i = 0; i < cells.Length; i++)
        {
            for (int j = i + 1; j < cells.Length; j++)
            {
                if((cells[i].GetComponent<ItemStat>().IndexItem != 0) & (cells[j].GetComponent<ItemStat>().IndexItem != 0))
                {
                    if (cells[i].GetComponent<ItemStat>().IndexItem == cells[j].GetComponent<ItemStat>().IndexItem)
                    {
                        maxNum++;
                        cells[j].GetComponent<ItemStat>().IndexItem = maxNum;
                    }
                }
                
            }
        }
    }
}
