/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: Game Timer

 * Methods: Start, Update, CountUp
    * Start - Finds the GameManager and sets the Timer
    * Update - Calls CountUp
    * CountUp - Starts the Timer when CountDown is done
 */

using System;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    private GameManager GMS;

    //Initial Time Given
    public uint startTime; 

    //Holds the Time Value
    private float timer;

    //String for outputting to GameObject
    private String timerText;

	void Start() {
        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
        timer = (float) startTime + 1;
    }
	
	void Update() {
        CountUp();
	}

    private void CountUp() {
        if(GMS.countdownDone == true) {
            //Count Up Timer
            timer += Time.deltaTime;
            timerText = string.Format("{0}:{1:00}", (int) timer / 60, (int) timer % 60);

            gameObject.GetComponent<Text>().text = "TIME: " + timerText;
        }
    }
}
