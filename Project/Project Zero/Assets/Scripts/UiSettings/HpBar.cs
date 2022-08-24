using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Slider slider;
    public PlayerControl _HpPlayer;

    private void Start()
    {
        SetMaxHP(_HpPlayer._PlayerHP);
    }
    private void Update()
    {
        SetHP(_HpPlayer._PlayerHP);
    }

    public void SetMaxHP(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHP(int health)
    {
        slider.value = health;
    }
}
