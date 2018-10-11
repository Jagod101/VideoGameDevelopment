/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Unity Programming CPSC 229
 * Return To Flavortown

 * Purpose: Collectible Items

 * Methods: OnTriggerEnter2D
 	* OnTriggerEnter2D: Checks for different collectibles and destroys after collected
 */

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {
	public int amount;

	void OnTriggerEnter2D(Collider2D other)
	{
			if(gameObject.CompareTag("GreenCollectible"))
			{
					//Debug.Log("Object G Identified");
					amount = 1;
					other.GetComponent<PointManager>().IncrementCount(amount);
			}
			else if(gameObject.CompareTag("YellowCollectible"))
			{
					//Debug.Log("Object Y Identified");
					amount = 2;
					other.GetComponent<PointManager>().IncrementCount(amount);
			}
			else if(gameObject.CompareTag("RedCollectible"))
			{
					//Debug.Log("Object R Identified");
					amount = 5;
					other.GetComponent<PointManager>().IncrementCount(amount);
			}
			Destroy(this.gameObject);
	}
}
