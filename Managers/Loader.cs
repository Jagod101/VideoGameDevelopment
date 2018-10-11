/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Unity Programming CPSC 229
 * Return To Flavortown

 * Purpose: Load Game Manager if it doesn't exist within the level

 * Methods: Start/Awake
 */

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

	public GameObject gameManager;

	// Use this for initialization
	void Awake () {
		if(GameManager.instance == null) {
			Instantiate(gameManager);
		}
	}
}
