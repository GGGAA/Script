using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Around : MonoBehaviour {

    public float xSpread;
    public float ySpread;
    public float xOffset;
    public float yOffset;
    public Transform centerPoint;
    public float rotSpeed;
    public bool rotateClockwise;
    float timer = 0;
	void Update () {
        timer += Time.deltaTime * rotSpeed;
        Rotate();
        transform.LookAt(centerPoint);
	}

    void Rotate()
    {
     if(rotateClockwise)
        {
            float x = -Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * xSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
     else
        {
            float x = Mathf.Cos(timer) * xSpread;
            float z = Mathf.Sin(timer) * xSpread;
            Vector3 pos = new Vector3(x, yOffset, z);
            transform.position = pos + centerPoint.position;
        }
    }


}
