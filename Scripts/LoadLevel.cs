using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {
    public void LoadLevels(int SceneIndex)
    {
        StartCoroutine(LoadAsynchronously(SceneIndex));
    }

    public Slider slider;

    IEnumerator LoadAsynchronously(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);

        while (!operation.isDone)
        {
           
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress; 
            yield return null;
        }
    }
}
