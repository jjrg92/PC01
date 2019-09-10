using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    
    float tx=0;
    float ty=0;

    void Update()
    {
        /*
        Vector3 mousePosition=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.Scale(new Vector3(1,1,0));
        transform.position=mousePosition;
        */

        tx += 0.01f;
        ty += 0.01f;

        float x = -5 + 10 * Mathf.PerlinNoise(tx,0);
        float y = -3 + 6 * Mathf.PerlinNoise(0,ty);
        transform.position=new Vector3(x,y,0);


    }
}
