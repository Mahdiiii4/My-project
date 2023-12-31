using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new UnityEngine.Vector3(0,0,speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new UnityEngine.Vector3(Time.deltaTime * -speed ,0,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new UnityEngine.Vector3(0,0,-speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new UnityEngine.Vector3(Time.deltaTime * speed,0,0);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position += new UnityEngine.Vector3(0,Time.deltaTime*speed*2,0);
        }
    }
}