using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCrash : MonoBehaviour {

    GameObject enemy;
    NPC enemyScript;

    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("NPC");
        enemyScript = enemy.GetComponent<NPC>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "NPC")
        {
            enemyScript.moveSpeed = 0;
        }
    }
}
