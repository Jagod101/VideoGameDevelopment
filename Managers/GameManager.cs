/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: GameManager

 * Methods: Update
 	* Update - Sets the CountDown to false when done
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public bool countdownDone = false;
	public GameObject CountDown;

	// Update is called once per frame
	void Update () {
		if(countdownDone) {
			CountDown.SetActive(false);
		}
	}
}
