﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    
    public float timer;
    public Text timerInGame;
    public Text timerCountdown;
    public Text position;

    GameObject player;
    BasicMovement ranks;
    Scene currScene;

	// Use this for initialization
	void Start () {
        timerInGame.gameObject.SetActive(false);
        timerCountdown.gameObject.SetActive(false);
        position.gameObject.SetActive(false);

        player = GameObject.FindGameObjectWithTag("Player");
        ranks = player.GetComponent<BasicMovement>();

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
