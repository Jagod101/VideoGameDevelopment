/*
 * Student Name: Zach Jagoda
 * Student ID: 2274813
 * Student Email: jagod101@mail.chapman.edu
 * Game Development
 * A Balancing Act

 * Purpose: Player Controller

 * Methods: Start, FixedUpdate, Update, Flip, OnTriggerEnter2D
    * Start - sets the GM, Anim, finds the Ground, and sets GameOver to false
    * FixedUpdate - used for player movement
	* Update - tracks the player jumping
	* Flip - flips the player model based on the direction they are facing
	* OnTriggerEnter2D - Triggers GameOver if player dies
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	//Game Manager
	private GameManager GMS;

    //Character Animator
    Animator anim;

    //Character
    public GameObject Player;

	//UI
	public GameObject gameOverScreen;

    //Character Attributes
    public float maxSpeed = 10f;
	bool facingRight = true;

	//Jump Mechanics
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;

	void Start(){
		GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
		anim = GetComponent<Animator>();
		groundCheck = transform.Find("GroundCheck");
        gameOverScreen.SetActive(false);
	}

	void FixedUpdate () {
		if(GMS.countdownDone == true) {
			//Jump
			grounded = false;
			Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, groundRadius, whatIsGround);
			for(int i = 0; i < colliders.Length; i++) {
				if(colliders[i].gameObject != gameObject) {
					grounded = true;
				}
			}

			anim.SetBool("Ground", grounded);

			anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

			//Move
			float move = Input.GetAxis("Horizontal");

			anim.SetFloat("Speed", Mathf.Abs(move));

			GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

			if(move > 0 && !facingRight) {
				Flip();
			}
			else if(move < 0 && facingRight) {
				Flip();
			}
		}
	}

	void Update() {
		if(GMS.countdownDone == true) {
			//Get Key for JUMPING
			if(grounded && Input.GetKeyDown("space")) {
				grounded = false;
				anim.SetBool("Ground", false);
				GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce));
			}
		}
    }

    void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

    void OnTriggerEnter2D(Collider2D other) {
		//Player takes Damage
		if(other.gameObject.CompareTag("Obstacle")) {
			Player.SetActive(false);
			gameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }

		if(other.gameObject.CompareTag("DeathZone")) {
			Player.SetActive(false);
			gameOverScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}