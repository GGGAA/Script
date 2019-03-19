using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour {

    public void Scenes()
    {
        GenerateRandomScene();
    }

    public void GenerateRandomScene()
    {
        int index;
        index = Random.Range(1, 6);

        switch (index)
        {
           case 1:
                SceneManager.LoadScene("Level01EL");
                Debug.Log(index);
                break;

           case 2:
                SceneManager.LoadScene("Level02EL");
                break;

           case 3:
                SceneManager.LoadScene("Level03EL");
                break;

           case 4:
                SceneManager.LoadScene("Level04EL");
                break;

            case 5:
                SceneManager.LoadScene("Level05EL");
                break;

            case 6:
                SceneManager.LoadScene("Level05EL");
                break;

        }              
    }
}
