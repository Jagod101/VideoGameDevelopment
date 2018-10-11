﻿/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: Main Menu Implementation

 * Methods: Start/Awake, newGame, quitGame
 	* newGame: loads desired scene for the main game
	* quitGame: exits out of the game
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	public string startLevel;

	//Overlays on the Menu Scene
	public GameObject Logo;
	public GameObject New;
	public GameObject Quit;

	public void Awake() {
		Logo.SetActive(true);
		New.SetActive(true);
		Quit.SetActive(true);;
	}

	public void newGame() {
		SceneManager.LoadScene(startLevel, LoadSceneMode.Single);
	}

	public void quitGame() {
		Application.Quit();
	}
}
