using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    
    float timer;
    public Text timerr;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        timer = Time.time;
        timerr.text = FormatTimer(timer);
    }

    private string FormatTimer(float timer) {
        float totalTime = timer;
        int hours = (int)(totalTime / 3600);
        int minutes = (int)(totalTime / 60) % 60;
        int seconds = (int)totalTime % 60;

        string time = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        return time;
    }
}
