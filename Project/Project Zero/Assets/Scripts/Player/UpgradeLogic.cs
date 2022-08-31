using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeLogic : MonoBehaviour
{
    public GameObject _ps;
    public GameObject menu;
    public static bool _Pause = false;
    public void StopMotion()
    {
        _ps.SetActive(false);
        _Pause = !_Pause;
        Time.timeScale = 0;
        if(UpgradeLogic._Pause == true)
        {
            menu.SetActive(true);
        }
    }
    private void Update()
    {
        if(UpgradeLogic._Pause == false)
        {
            _ps.SetActive(true);
        }
    }
}
