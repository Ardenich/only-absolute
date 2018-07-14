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
    public Text oldRank;
    public Text rank;
    public Button backButton;

    int ranks;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        time = player.GetComponent<Timer>();
        speed = player.GetComponent<BasicMovement>();

        times.gameObject.SetActive(false);
        finish.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        rank.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            times.text = time.timerInGame.text;
            oldTimer.gameObject.SetActive(false);
            times.gameObject.SetActive(true);
            finish.gameObject.SetActive(true);
            backButton.gameObject.SetActive(true);
            oldRank.gameObject.SetActive(false);
            rank.gameObject.SetActive(true);
            if (ranks == 0)
            {
                rank.text = "You placed 1st";
            }
            if (ranks == 1)
            {
                rank.text = "You placed 2nd";
            }
            if (ranks == 2)
            {
                rank.text = "You placed 3rd";
            }
            if (ranks == 3)
            {
                rank.text = "You placed 4th";
            }

            speed.rb.drag = 3;
        }
        if (other.tag == "NPC")
        {
            ranks++;
        }
    }
}
