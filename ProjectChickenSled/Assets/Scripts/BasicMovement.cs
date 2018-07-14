using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {
    
    float move;
    float steer;
    float turnSpeed = 1f;
    float brake = 3f;
<<<<<<< HEAD
    float moveSpeed = 200f;
=======
    public float moveSpeed = 300f;
>>>>>>> cf708461c1b23e010f9dfe4521a1eccefac675dd
    public float timer;

    public Rigidbody rb;

    public int rank;
    public GameObject tracer;
    Positioning ranker;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 cog = new Vector3(0, 0, 0);
        rb.centerOfMass = cog;

        ranker = tracer.GetComponent<Positioning>();
    }

    // Update is called once per frame

    void Update()
    {
        timer = Time.timeSinceLevelLoad;
        rank = ranker.playerRank;
    }
    
    void FixedUpdate ()
    {
        steer = Input.GetAxis("Horizontal");
        move = Input.GetAxis("Vertical");
        
        rb.drag = (((move * (-1)) / brake) + 1);
        if (timer > 3)
        {
            rb.AddForce(transform.forward * moveSpeed);
        }
        transform.Rotate(0, steer * turnSpeed, 0);
    }
<<<<<<< HEAD
=======

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            float exitTime = timer;
            Vector3 lastPos = transform.position;
            moveSpeed = 10;
            if (timer >= exitTime + 5)
            {
                transform.position = lastPos;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            moveSpeed = 300;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FinishLine")
        {
            moveSpeed = 0;
        }
    }
>>>>>>> cf708461c1b23e010f9dfe4521a1eccefac675dd
}
