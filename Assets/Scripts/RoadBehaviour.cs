using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBehaviour : MonoBehaviour
{
    private Rigidbody rb;
    
    private Vector3 constantVelocity = new Vector3(0,0, -20);
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()    
    {
        rb.velocity = constantVelocity;
    }
}
