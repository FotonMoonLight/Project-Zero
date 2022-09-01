using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelecterUi : MonoBehaviour
{
   public void InfinityMode()
    {
        SceneManager.LoadScene("ClassSelect");
    }
    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
