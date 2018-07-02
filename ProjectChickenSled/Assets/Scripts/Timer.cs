using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    
    public float timer;
    public Text timerr;
    public Text timmer;


	// Use this for initialization
	void Start () {
        timerr.gameObject.SetActive(false);
        timmer.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        timer = Time.time - 4;
        if (timer < 0)
        {
            timmer.gameObject.SetActive(true);
        } else
        {
            timmer.gameObject.SetActive(false);
            timerr.gameObject.SetActive(true);
        }
        timmer.text = FormatTimer(timer);
        timerr.text = FormatTimer(timer);
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
