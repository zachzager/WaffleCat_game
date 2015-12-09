using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;

public class playerNetworkBehavior : NetworkBehaviour {
	
	public Text scoreText;
	public Text winText;
	
	private Rigidbody2D body;
	private string direction;
	private string LEFT = "left";
	private string RIGHT = "right";
	private float maxSpeed;
	private int score;
	private int winScore;
	
	void Start() {
		body = GetComponent <Rigidbody2D> ();
		direction = LEFT;
		maxSpeed = 10;
		score = 0;
		winScore = 1000;
		setScoreText ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		limitSpeed ();
		checkforWin ();
	}
	
	// moves character vertically and handles jumping input
	void Move () {
		
		if (direction == RIGHT) { // right
			body.AddForce(transform.right * 3);
		} 
		
		if (direction == LEFT) { // left
			body.AddForce(transform.right * -3);
		}

		// checks if local player, jumps
		if (isLocalPlayer) {
			if (gameObject.tag == "Player 1" && Input.GetKeyDown (KeyCode.Space)) {
				body.AddForce (new Vector2 (0, 6), ForceMode2D.Impulse);
			}
		}
	}
	
	// detects collisions with walls to:
	//	1. change directions
	//  2. bounce upward off wall
	//
	// detects collisions with collectablses to:
	// 	1. increment score
	void OnCollisionEnter2D(Collision2D coll) {
		
		// ALTERNATES DIRECTIONS when player hits walls
		if (coll.gameObject.tag == "Wall") {
			if (direction == LEFT) {
				direction = RIGHT;
				body.AddForce(new Vector2(0,3), ForceMode2D.Impulse);
			} else if (direction == RIGHT) {
				direction = LEFT;
				body.AddForce(new Vector2(0,3), ForceMode2D.Impulse);
			}
		} 
		
		// player collision interaction (bounce, switch direction)
		if (coll.gameObject.tag == "Player 1" || coll.gameObject.tag == "Player 2") {
			
			// calculates colliding object velocity
			Vector2 bounceVec = body.velocity - coll.relativeVelocity;
			
			// adds bounce force to player
			body.AddForce(new Vector2(bounceVec.x,bounceVec.y), ForceMode2D.Impulse);
			
			// switches player directions when bouncing
			if (bounceVec.x > 0) {
				direction = RIGHT;
			} else if (bounceVec.x < 0) {
				direction = LEFT;
			}
		}
	}
	
	// detects collision with collectables
	void OnTriggerEnter2D(Collider2D coll) {
		
		// increments score when player gets collectables 
		if (coll.gameObject.tag == "collectable") {
			score = score + 100;
			setScoreText();
		}
	}
	
	// sets the score text
	void setScoreText() {
		
		// Player 1 score text
		if (gameObject.tag == "Player 1") {
			scoreText.text = "Cat 1: " + score.ToString ();
		} 
		
		// Player 2 score text
		else if (gameObject.tag == "Player 2") {
			scoreText.text = "Cat 2: " + score.ToString ();
		}
	}
	
	// checks if a player wins, if so which player
	void checkforWin() {
		if (score == winScore) {
			if (gameObject.tag == "Player 1") {
				StartCoroutine(displayWinText("Cat 1")); // Player 1 score text
			}
			else if (gameObject.tag == "Player 2") {
				StartCoroutine(displayWinText("Cat 2")); // Player 2 score text
			}
		}
		
	}
	
	// displays "Cat X Wins!"
	IEnumerator displayWinText(string winner) {
		winText.text = winner + " Wins!";
		Time.timeScale = 0.75F;
		yield return new WaitForSeconds(3);
		Application.LoadLevel (0);
	}
	
	
	// limits speed
	void limitSpeed() {
		if(body.velocity.magnitude > maxSpeed) {
			body.velocity = body.velocity.normalized * maxSpeed;
		}
	}
	
	// changes the scene
	void loadLevel (int sceneNumber) {
		Application.LoadLevel (sceneNumber);
	}
}
