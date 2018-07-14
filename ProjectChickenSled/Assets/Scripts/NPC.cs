using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    float turnSpeed = 3f;
    float brake = 3f;
    public float moveSpeed;

    public GameObject trace;

    public float timer;
    float speed;
    float turning;

    float accelerate = 0;

    public Rigidbody rb;

    float distGround;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 cog = new Vector3(0, -1, 0);
        rb.centerOfMass = cog;

        if (this.name == "Cow") moveSpeed = 23f;
        if (this.name == "Dog") moveSpeed = 24f;
        if (this.name == "Sheep") moveSpeed = 25f;
    }

    // Update is called once per frame

    void Update()
    {
        if (accelerate <1) accelerate += 0.001f;
        timer = Time.time;
        turning = turnSpeed * Time.deltaTime;
        speed = accelerate * moveSpeed * Time.deltaTime;

        Vector3 direction = trace.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, turning);

        if (timer > 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, trace.transform.position, speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FinishLine")
        {
            moveSpeed = 0;
        }
    }
}
