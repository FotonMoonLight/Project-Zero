using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStat : MonoBehaviour
{
    public Sprite s;
    public int IndexItem = 0;
    public GameObject player;

    [Header("Список булевых")]
    private bool _HasRegen = true;

    public void Update()
    {
        if(UpgradeLogic._Pause == false)
        {
            HpRegen();
        }
    }
    private void HpRegen()
    {
        
        if (IndexItem == 1)
        {
            gameObject.GetComponent<Image>().sprite = s;
        }
        if (IndexItem == 1 & player.GetComponent<PlayerControl>()._PlayerHP < 20 & _HasRegen==true)
        {
            player.GetComponent<PlayerControl>()._PlayerHP += 1;
            _HasRegen = false;
            StartCoroutine(regenTimer());
            
        }
    }
    IEnumerator regenTimer()
    {
        yield return new WaitForSeconds(4f);
        _HasRegen = true;
    }
}
