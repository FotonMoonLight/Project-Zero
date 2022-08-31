using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicForPause : MonoBehaviour
{
    public GameObject mn;
    
    public void Start()
    {
        mn = GameObject.Find("MenuCanvas");
    }

    public void ContButton()
    {
        UpgradeLogic._Pause = false;
        mn.SetActive(false);
        Time.timeScale = 1;
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
