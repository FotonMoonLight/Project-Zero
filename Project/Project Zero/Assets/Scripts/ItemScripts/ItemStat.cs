using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStat : MonoBehaviour
{
    public int IndexItem;
    public GameObject player;

    [Header("Список булевых")]
    private bool _HasRegen = true;

    public void Update()
    {
        HpRegen();
    }
    private void HpRegen()
    {
        if(IndexItem == 0 & player.GetComponent<PlayerControl>()._PlayerHP < 20 & _HasRegen==true)
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
