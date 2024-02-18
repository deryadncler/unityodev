using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
  public void CikisButonu()
    {
        Application.Quit();
    }
    public void YeniOyun()
    {
        SceneManager.LoadScene(1);
    }
    public void LevelSahne()
    {
        SceneManager.LoadScene(0);
    }
    public void OptionsSceneBack()
    {
        SceneManager.LoadScene(0);
    }
    public void OptionsScene()
    {
        SceneManager.LoadScene(2);
    }
    public void seviye1()
    {
        SceneManager.LoadScene(3);
    }
    public void seviye2()
    {
        SceneManager.LoadScene(4);
    }
    
    
}
