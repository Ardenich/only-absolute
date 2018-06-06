using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
    
    float move;
    float steer;
    float turnSpeed = 1f;
    float brake = 3f;
    float moveSpeed = 60f;

    Rigidbody rb;

    float distGround;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 cog = new Vector3(0, 0, 0);
        rb.centerOfMass = cog;
    }

    // Update is called once per frame

    void Update()
    {
        
    }
    
    void FixedUpdate ()
    {
        steer = Input.GetAxis("Horizontal");
        move = Input.GetAxis("Vertical");
        
        rb.drag = (move * (-1)) / brake;
        if(GroundCheck()) rb.AddForce(transform.forward * moveSpeed);
        transform.Rotate(0, steer * turnSpeed, 0);
    }


    bool GroundCheck()
    {
        return Physics.Raycast(transform.position, Vector3.down, distGround + 0.1f);
    }
}
