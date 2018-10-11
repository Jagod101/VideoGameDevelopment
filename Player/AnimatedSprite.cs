/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Unity Programming CPSC 229
 * Return To Flavortown

 * Purpose: AnimatedSprite for Menu

 * Methods: Start/Awake, Update
 	* Awake: Set Actives
	* Update: Move the Player based on the Rigidbody
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedSprite : MonoBehaviour {
	//Speed at which Animated Sprite Moves
	public float moveSpeed;

	//Identifies when to hide sprite
	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	private bool hittingWall;

	public GameObject regularFieri;
	public GameObject cartFieri;

	// Use this for initialization
	void Start () {
		regularFieri.SetActive(true);
		cartFieri.SetActive(false);
	}

	// Update is called once per frame
	void Update () {
		hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if(hittingWall) {
			cartFieri.SetActive(true);
			regularFieri.SetActive(false);
		}
	}
}
