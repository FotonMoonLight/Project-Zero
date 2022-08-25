using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Slider _Hpslider;
    public Slider _ManaSlider;
    public PlayerControl _HpPlayer;

    private void Start()
    {
        SetMaxHP(_HpPlayer._PlayerHP);
        SetMaxMana(_HpPlayer._PlayerMana);
    }
    private void Update()
    {
        SetHP(_HpPlayer._PlayerHP);
        SetMp(_HpPlayer._PlayerMana);
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
