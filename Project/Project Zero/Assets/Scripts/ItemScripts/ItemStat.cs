using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStat : MonoBehaviour
{
    public Sprite[] texture;
    public int IndexItem = 0;
    public static int MaxHpI = 20;
    public static int MaxMpI = 20;
    public GameObject player;

    [Header("Список булевых")]
    public static bool _GiveHp = true;
    public static bool _GiveMp = true;
    private bool MpRegenMax = true;
    private bool _HasRegen = true;
    private bool _GiveSpeed = true;
    private bool _TextureChange = true;

    public void Update()
    {
        if(UpgradeLogic._Pause == false)
        {
            HpRegen();
            MpRegen();
            MaxHp();
            MaxMp();
            MaxSpeed();
        }
        if(IndexItem > 0 & _TextureChange == true)
        {
            gameObject.GetComponent<Image>().sprite = texture[IndexItem];
            _TextureChange = false;
        }
        
    }

    private void MaxHp()
    {
        if(_GiveHp == true & IndexItem == 1)
        {
            player.GetComponent<PlayerControl>()._PlayerHP += 10;
            MaxHpI += 10;
            _GiveHp = false;
        }
        
    }
    private void MaxMp()
    {
        if (_GiveMp == true & IndexItem == 2)
        {
            player.GetComponent<PlayerControl>()._PlayerMana += 10;
            MaxMpI += 10;
            _GiveMp = false;
        }
    }
    private void HpRegen()
    {
        if (IndexItem == 3 & player.GetComponent<PlayerControl>()._PlayerHP < 20 & _HasRegen==true)
        {
            player.GetComponent<PlayerControl>()._PlayerHP += 1;
            _HasRegen = false;
            StartCoroutine(regenTimer());
            
        }
    }
    private void MpRegen()
    {
        if(IndexItem == 4 & MpRegenMax == true)
        {
            player.GetComponent<PlayerControl>()._ManaRegenTime -= 0.5f;
            MpRegenMax = false;
        }
    }
    private void MaxSpeed()
    {
        if(IndexItem == 5 & _GiveSpeed == true)
        {
            player.GetComponent<PlayerControl>()._MovementSpeed += 0.5f;
            _GiveSpeed = false;
        }
    }
    IEnumerator regenTimer()
    {
        yield return new WaitForSeconds(4f);
        _HasRegen = true;
    }
}
