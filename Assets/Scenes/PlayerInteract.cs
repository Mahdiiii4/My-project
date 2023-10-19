using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public Transform target;
    float distance = Vector3.Distance(transform.position, target.position);
    void Update()
    {
        if(distance <= 10)
        {
            Debug.Log("Hello");
        }

    }
}
