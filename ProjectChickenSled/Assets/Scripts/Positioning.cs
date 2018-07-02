using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positioning : MonoBehaviour {

    public GameObject char1;
    public GameObject char2;
    public GameObject char3;
    public GameObject char4;

    public float distance1;
    float distance2;
    float distance3;
    float distance4;

    public int playerRank;

	void Update () {
        distance1 = Vector3.Distance(transform.position, char1.transform.position);
        distance2 = Vector3.Distance(transform.position, char2.transform.position);
        distance3 = Vector3.Distance(transform.position, char3.transform.position);
        distance4 = Vector3.Distance(transform.position, char4.transform.position);

        if (distance1 <= distance2 && distance1 <= distance3 && distance1 <= distance4)
        {
            playerRank = 1;
        }
        if (distance2 <= distance1 && distance2 <= distance3 && distance2 <= distance4)
        {
            playerRank = 2;
        }
        if (distance3 <= distance1 && distance3 <= distance2 && distance3 <= distance4)
        {
            playerRank = 3;
        }
        if (distance4 <= distance1 && distance3 <= distance2 && distance3 <= distance3)
        {
            playerRank = 4;
        }
    }
}
