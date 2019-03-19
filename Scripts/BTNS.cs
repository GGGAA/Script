using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTNS : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene("Play");
    }

   public void Hard()
   {
        SceneManager.LoadScene("HardLevels");
   }

    public void Medium()
    {
        SceneManager.LoadScene("MediumLevels");
    }

    public void Easy()
    {
        SceneManager.LoadScene("EasyLevels");
    }

    public void Inapoi()
    {
        SceneManager.LoadScene("Play");
    }

    public void LVL1()
    {
        SceneManager.LoadScene("Level01EL");
    }

    public void LVL2()
    {
        SceneManager.LoadScene("Level02EL");
    }

    public void LVL3()
    {
        SceneManager.LoadScene("Level03EL");
    }

    public void LVL4()
    {
        SceneManager.LoadScene("Level04EL");
    }

    public void LVL5()
    {
        SceneManager.LoadScene("Level05EL");
    }

    public void LVL6()
    {
        SceneManager.LoadScene("Level06EL");
    }


    public void Quit()
    {
        Application.Quit();
    }
}
