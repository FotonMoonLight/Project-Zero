using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiClassSelectScene : MonoBehaviour
{
    public static int _ClassId;
    public void ReturnButton()
    {
        SceneManager.LoadScene("LevelSelecter");
    }
    public void ClassSelectZero()
    {
        SceneManager.LoadScene("ClassView");
    }
    public void ReturnInClassChoose()
    {
        SceneManager.LoadScene("ClassSelect");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void ResturtButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
