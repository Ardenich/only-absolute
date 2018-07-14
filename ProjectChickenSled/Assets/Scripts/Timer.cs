using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    
    public float timer;
<<<<<<< HEAD
    public Text timerr;
    public Text timmer;
=======
    public Text timerInGame;
    public Text timerCountdown;
    public Text position;
>>>>>>> cf708461c1b23e010f9dfe4521a1eccefac675dd

    GameObject player;
    BasicMovement ranks;
    Scene currScene;

	// Use this for initialization
	void Start () {
<<<<<<< HEAD
        timerr.gameObject.SetActive(false);
        timmer.gameObject.SetActive(false);
=======
        timerInGame.gameObject.SetActive(false);
        timerCountdown.gameObject.SetActive(false);
        position.gameObject.SetActive(false);

        player = GameObject.FindGameObjectWithTag("Player");
        ranks = player.GetComponent<BasicMovement>();
<<<<<<< HEAD
>>>>>>> cf708461c1b23e010f9dfe4521a1eccefac675dd
	}
	
	// Update is called once per frame
	void Update () {
        timer = Time.time - 4;
        if (timer < 0)
        {
            timmer.gameObject.SetActive(true);
        } else
        {
<<<<<<< HEAD
            timmer.gameObject.SetActive(false);
            timerr.gameObject.SetActive(true);
        }
        timmer.text = FormatTimer(timer);
        timerr.text = FormatTimer(timer);
=======
            timerCountdown.gameObject.SetActive(false);
            timerInGame.gameObject.SetActive(true);
            position.gameObject.SetActive(true);
        }
        timerCountdown.text = FormatTimer(timer);
        timerInGame.text = FormatTimer(timer);
        position.text = ranks.rank.ToString() + "/4";
>>>>>>> cf708461c1b23e010f9dfe4521a1eccefac675dd
=======

        currScene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
        timer = (Time.timeSinceLevelLoad) -4;
            if (timer < 0)
            {
                timerCountdown.gameObject.SetActive(true);
            }
            else
            {
                timerCountdown.gameObject.SetActive(false);
                timerInGame.gameObject.SetActive(true);
                position.gameObject.SetActive(true);
            }
            timerCountdown.text = FormatTimer(timer);
            timerInGame.text = FormatTimer(timer);
            position.text = ranks.rank.ToString() + "/4";
>>>>>>> 1b7ecc32c59cf457c12134bf7f7e9a861a379a99
    }

    private string FormatTimer(float timer)
    {
        
        if (timer > 0)
        {
            float totalTime = timer;
            int hours = (int)(totalTime / 3600);
            int minutes = (int)(totalTime / 60) % 60;
            int seconds = (int)totalTime % 60;

            string time = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            return time;
        } else
        {
            float totalTime = timer;
            int hours = (int)(totalTime / 3600);
            int minutes = (int)(totalTime / 60) % 60;
            int seconds = ((int)totalTime % 60) * -1;

            string time = string.Format("{0:0}", seconds);
            return time;
        }
    }
}
