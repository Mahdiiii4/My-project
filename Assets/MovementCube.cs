using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovementCube : MonoBehaviour
{
    public float speed = 1f;
    bool moveUpZ = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z <= 7 && !moveUpZ)
        {
            transform.position += new Vector3(0,0,speed * Time.deltaTime);
        }
        else if(transform.position.z >=-7)
        {
            moveUpZ = true;
            transform.position += new Vector3(0,0,-speed * Time.deltaTime);
        }
        else
        {
            moveUpZ = false;
        }
    }
}