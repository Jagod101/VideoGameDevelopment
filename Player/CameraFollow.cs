/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Unity Programming CPSC 229
 * Return To Flavortown

 * Purpose: Follow the Player on the X-Axis only

 * Methods: Update
 	* Update: Update the Camera Position on the X-Axis based on the Player's Position
 */

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform Camera;
	public Transform Player;

	// Update is called once per frame
	void Update () {
		Camera.position = new Vector3(Player.position.x, 3, -7);
	}
}
