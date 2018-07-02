using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCrash : MonoBehaviour {

    public int collide;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "NPC")
        {
            this.gameObject.SetActive(false);
            collide = 1;
        }
    }
}
