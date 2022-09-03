using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiButton : MonoBehaviour
{
 
    public InputField _MaxFrameRate;
    public GameObject[] firtsSee;
    public GameObject[] setting;
    
   public void StartButton()
    {
        SceneManager.LoadScene("LevelSelecter");
    }
    public void SettingButton()
    {
        for(int i = 0;i < firtsSee.Length; i++)
        {
            firtsSee[i].SetActive(false);
        }
        for (int a = 0; a < setting.Length; a++)
        {
            setting[a].SetActive(true);
        }
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void ApplySettings()
    {
        string txt = _MaxFrameRate.text;
        int x = int.Parse(txt);
        GameManager._FrameRate = x;

    }
    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
