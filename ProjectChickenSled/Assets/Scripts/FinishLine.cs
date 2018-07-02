using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {

    GameObject player;
    Timer time;
    BasicMovement speed;

    public Text times;
    public Text finish;
    public Text oldTimer;


    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        time = player.GetComponent<Timer>();
        speed = player.GetComponent<BasicMovement>();

        times.gameObject.SetActive(false);
        finish.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            times.text = time.timerr.text;
            DestroyObject(oldTimer);
            times.gameObject.SetActive(true);
            finish.gameObject.SetActive(true);
            speed.rb.drag = 3;
            
        }
    }
}
