using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    Vector3 velocity, steer, desired = Vector3.zero;
    float maxSpeed=10;
    float maxSteer=10;
    public bool alejar=false;

    Transform target;

    void Update()
    {
        target=GameObject.Find("Target").transform;
        
        if(alejar==true)
        {
            //Se calcula el deseado (desired)
            desired=-(target.position-transform.position).normalized*maxSpeed;
        }
        else
        {
            //Se calcula el deseado (desired)
            desired=(target.position-transform.position).normalized*maxSpeed;
        }
        
        //Calculamos el steer
        steer=Vector3.ClampMagnitude(desired-velocity,maxSteer);

        velocity+=steer*Time.deltaTime;
        transform.position+=velocity*Time.deltaTime;
    }

}
