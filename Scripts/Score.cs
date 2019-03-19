using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public static int PinCount;

    public Text text;

    public string str;
    void Start()
    {
        PinCount = 0;
    }
    public void Update()
    {
        text.text = PinCount.ToString(str);
    }
}