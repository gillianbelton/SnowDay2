using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TimerScript : MonoBehaviour {

	public float timeLeft;// = 299.9f;
	public Text timerText; 

	// Use this for initialization
	void Start () {
		timerText.text = "Time Left: 5:00";
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0) {
			timerText.text = "Game over, time's up!"; 
		} else {
			int second = (int) Math.Round(timeLeft % 60);
			int minute = (int) Math.Floor(timeLeft / 60);
			timerText.text = "Time Left: " + minute + ":" + second;

		}
	}
}
