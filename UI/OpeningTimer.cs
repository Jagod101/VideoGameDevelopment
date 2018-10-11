/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: Game Timer

 * Methods: Start/Awake, Update, CountDown, DeactivateTimer
 	* 
 */

using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OpeningTimer : MonoBehaviour {
    //Opening Timer GameObject
    public GameObject openingTimer;

    //Initial Time Given
    public uint startTime; 

    //Holds the Time Value
    private float timer;

    //String for outputting to GameObject
    private String timerText;

	void Start() {
        openingTimer.SetActive(true);
        timer = (float) startTime + 1;
    }
	
	void Update() {
        CountDown();
	}

    private void CountDown() {
        if(timer > 0) {
            //Count Down Timer
            timer -= Time.deltaTime;
            timerText = string.Format("{00}", (int) timer / 60, (int) timer % 60);

            gameObject.GetComponent<Text>().text = timerText;
        }
        else if(timer < 0) {
            gameObject.GetComponent<Text>().text = "GO!";
            DeactivateTimer();
        }
    }

    public void DeactivateTimer() {
        openingTimer.SetActive(false);
    }
}