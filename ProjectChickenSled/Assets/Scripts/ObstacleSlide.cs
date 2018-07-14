using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSlide : MonoBehaviour {

    private IEnumerator OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "NPC")
        {
            other.gameObject.transform.Rotate(0, 10, 0);
        }
        yield return new WaitForSeconds(2);
        this.gameObject.SetActive(false);
    }
}
