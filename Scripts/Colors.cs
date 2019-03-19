using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour {

    public string currentColor;
    public Color colorYellow, colorGreen, colorBlue, colorOrange, colorPynk, colorRed;
    public SpriteRenderer sr;
   //  public Camera camera;

	// Use this for initialization
	void Start () {
        GenerateRandomColor();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GenerateRandomColor()
    {

        int index = Random.Range(0, 5);

        switch (index)
        {
            case 0 :
                currentColor = "Blue";
               sr.color = colorBlue;
              //  camera.backgroundColor = colorBlue;
                break;
            case 1:
                currentColor = "Red";
                sr.color = colorRed;
              //  camera.backgroundColor = colorRed;
                break;
            case 2:
                currentColor = "Pynk";
             //   camera.backgroundColor = colorPynk;
                sr.color = colorPynk;
                break;
            case 3:
                currentColor = "Orange";
              //  camera.backgroundColor = colorOrange;
                sr.color = colorOrange;
                break;
            case 4:
                currentColor = "Green";
              //  camera.backgroundColor = colorGreen;
                sr.color = colorGreen;
                break;
            case 5:
                currentColor = "Yellow";
             //   camera.backgroundColor = colorYellow;
                sr.color = colorYellow;
                break;

        }
    }
}
