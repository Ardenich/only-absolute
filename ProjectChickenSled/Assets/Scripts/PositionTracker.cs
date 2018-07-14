using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTracker : MonoBehaviour {

    public GameObject tracker;
    public GameObject track1;
    public GameObject track2;
    public GameObject track3;
    public GameObject track4;
    public GameObject track5;
    public GameObject track6;
    public int trackerNumber;

    void Update()
    {
        if (trackerNumber == 0)
        {
            tracker.transform.position = track1.transform.position;
        }
        if (trackerNumber == 1)
        {
            tracker.transform.position = track2.transform.position;
        }
        if (trackerNumber == 2)
        {
            tracker.transform.position = track3.transform.position;
        }
        if (trackerNumber == 3)
        {
            tracker.transform.position = track4.transform.position;
        }
        if (trackerNumber == 4)
        {
            tracker.transform.position = track5.transform.position;
        }
        if (trackerNumber == 5)
        {
            tracker.transform.position = track6.transform.position;
        }
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            trackerNumber += 1;
            if (trackerNumber == 6)
            {
                trackerNumber = 0;
            }
        }
        yield return new WaitForSeconds(1);
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
