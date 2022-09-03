using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Slider _Hpslider;
    public Slider _ManaSlider;
    public Slider _OzSlider;
    public PlayerControl _HpPlayer;
    public static int maxOz = 3;
    public bool HpUp = true;
    public bool MpUp = true;
    public static bool LevelUp = false;

    private void Start()
    {
        SetMaxHP(_HpPlayer._PlayerHP);
        SetMaxMana(_HpPlayer._PlayerMana);
        SetMaxOz(maxOz);
    }
    private void Update()
    {
        if(LevelUp == true)
        {
            SetMaxOz(maxOz += 1);
            LevelUp = false;
        }
        if(ItemStat._GiveHp == false & HpUp == true)
        {
            SetMaxHP(ItemStat.MaxHpI);
            HpUp = false;
        }
        if(ItemStat._GiveMp == false & MpUp == true)
        {
            SetMaxMana(ItemStat.MaxMpI);
            MpUp = false;
        }
        SetHP(_HpPlayer._PlayerHP);
        SetMp(_HpPlayer._PlayerMana);
        SetOz(_HpPlayer._PlayerOz);
    }
    public void SetOz(int Oz)
    {
        _OzSlider.value = Oz;
    }
    public void SetMaxOz(int Oz)
    {
        _OzSlider.maxValue = maxOz;
        _OzSlider.value = Oz;
    }
    public void SetMaxMana(int Mp)
    {
        _ManaSlider.maxValue = Mp;
        _ManaSlider.value = Mp;
    }
    public void SetMp(int Mp)
    {
        _ManaSlider.value = Mp;
    }
    public void SetMaxHP(int health)
    {
        _Hpslider.maxValue = health;
        _Hpslider.value = health;
    }
    public void SetHP(int health)
    {
        _Hpslider.value = health;
    }
}
