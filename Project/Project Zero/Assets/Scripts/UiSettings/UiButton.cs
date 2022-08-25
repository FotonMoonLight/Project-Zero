using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiButton : MonoBehaviour
{
    public GameObject[] firtsSee;
    public GameObject[] setting;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   public void StartButton()
    {
        SceneManager.LoadScene("ClassSelect");
    }
    public void SettingButton()
    {
        for(int i = 0;i <= firtsSee.Length; i++)
        {
            firtsSee[i].SetActive(false);
        }
        for (int a = 0; a <= setting.Length; a++)
        {
            setting[a].SetActive(true);
        }
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    
}
