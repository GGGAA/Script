using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ProgressBarr : MonoBehaviour {

    public Slider slider;
    public Transform LoadingBar;
    public float fillAmount = 0f;
    public float currentAmount = 0f;
    public Rotater rotater;
    const float superProgress = 20f;

    // Use this for initialization
    void Start() {
        slider = GetComponent<Slider>();
    }
    // Update is called once per frame

    void Update() {
        
        if (Input.GetButtonDown("Fire1"))
        {
            slider.value = fillAmount;
            fillAmount++;
            currentAmount++;
        }

        if(slider.value == superProgress)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }   
}