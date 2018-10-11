/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Unity Programming CPSC 229
 * Return To Flavortown

 * Purpose: PointManager to keep track of the overall point counter and Flave-O-Meter

 * Methods: IncrementCount, afterActivation
 	* IncrementCount: Update Display Count and Flave-O-Meter Slider
	* afterActivation: Reset the slider progress so it can refill
 */

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour {
	private int amount;
	public int counter;
	public int sliderProgress;
	public int maxSlider = 20;
	public bool powered = false;
	public string textCount;
	public string finalCount;

	public GameObject displayCount;
	public GameObject FlaveOMeter;
	public Slider powerUpSlider;
	public GameObject finalScore;

	public void IncrementCount(int amount) {
		counter = counter + amount;
		displayCount.GetComponent<Text>().text = textCount + counter.ToString();
		finalScore.GetComponent<Text>().text = finalCount + counter.ToString();

		if(sliderProgress <= maxSlider) {
			sliderProgress = sliderProgress + amount;
			powerUpSlider.value = sliderProgress;
		}

		if(sliderProgress >= maxSlider) {
			//Activate Power Up Option
			powered = true;
			GetComponent<PlayerController>().PowerUp(powered);
		}
	}

	public void afterActivation() {
		sliderProgress = 0;
		powerUpSlider.value = sliderProgress;
	}
}
