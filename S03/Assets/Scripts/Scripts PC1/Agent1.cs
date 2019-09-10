using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent1 : MonoBehaviour
{
    Vector3 velocity, steer, desired = Vector3.zero;
    float maxSpeed=10;
    float maxSteer=10;

    Transform mouse;
    bool victoria=false;

    void Update()
    {
        mouse=GameObject.Find("Mouse").transform;
        
        desired=-(mouse.position-transform.position).normalized*maxSpeed;

        steer=Vector3.ClampMagnitude(desired-velocity,maxSteer);

        velocity+=steer*Time.deltaTime;

        transform.position+=velocity*Time.deltaTime;

        Vector3 cameraPosition=Camera.main.ScreenToWorldPoint(transform.position);
        
        if(transform.position.x >= -1 && transform.position.x <= 1 && transform.position.y >= -1 && transform.position.y <= 1)
        {
            Debug.Log("You Win");
            Destroy(gameObject);
            victoria=true;
        }

   }

   void OnBecameInvisible()
   {
        if(victoria==false)
        {
            Debug.Log("You Lose");
            Destroy(gameObject);
        }
   }

}
