/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: Set Count Down

 * Methods: SetCountDown
 	* SetCountDownTimer - Finds the GameManager and when countdownDone sets to true
 */
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountDown : MonoBehaviour {

	private GameManager GMS;

	public void SetCountDownTimer() {
		GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
		GMS.countdownDone = true;
	}
}
