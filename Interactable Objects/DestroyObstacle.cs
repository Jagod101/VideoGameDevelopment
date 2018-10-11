/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: Destroy Obstacles

 * Methods: OnTriggerEnter2D
 	* OnTriggerEnter2D - When an object with the tag "Obstacle" enters the collider the object is Destroyed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Obstacle") {
			Destroy(other.gameObject);
		}
	}
}
