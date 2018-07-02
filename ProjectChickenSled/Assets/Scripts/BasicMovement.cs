using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
    
    float move;
    float steer;
    float turnSpeed = 1f;
    float brake = 3f;
    float moveSpeed = 200f;
    public float timer;

    public Rigidbody rb;

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
        timer = Time.time;
    }
    
    void FixedUpdate ()
    {
        steer = Input.GetAxis("Horizontal");
        move = Input.GetAxis("Vertical");
        
        rb.drag = (move * (-1)) / brake;
        if (timer > 3)
        {
            rb.AddForce(transform.forward * moveSpeed);
        }
        transform.Rotate(0, steer * turnSpeed, 0);
    }
}
