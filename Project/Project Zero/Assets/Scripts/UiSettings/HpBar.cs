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

    private void Start()
    {
        SetMaxHP(_HpPlayer._PlayerHP);
        SetMaxMana(_HpPlayer._PlayerMana);
        SetMaxOz(_HpPlayer._PlayerOz);
    }
    private void Update()
    {
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
        _OzSlider.maxValue = 100;
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
