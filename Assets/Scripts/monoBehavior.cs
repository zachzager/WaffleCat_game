using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;

public class monoBehavior : NetworkBehaviour {

	public Text scoreText;

	private Rigidbody2D body;
	//[SyncVar]
	//private Vector2 syncPos; 
	private string direction;
	private string LEFT = "left";
	private string RIGHT = "right";
	private float maxSpeed;
	private int score;
	//private float token = 0.15f;

	void Start() {
		body = GetComponent <Rigidbody2D> ();
		direction = LEFT;
		maxSpeed = 10;
		score = 0;
		setText ();
	}

	/*
	void FixedUpdate(){
		TransmitPosition();
		GotoPosition();	
	}


	void GotoPosition()
	{
		if(!isLocalPlayer)
		{
			transform.position = Vector2.MoveTowards(transform.position, syncPos, token);
		}
	}


	[Command]
	void CmdProvidePositionToServer(Vector2 pos)
	{
		syncPos = pos;
	}
	
	
	[ClientCallback]
	void TransmitPosition()
	{
		CmdProvidePositionToServer(transform.position);
	}
*/

	// Update is called once per frame
	void Update () {
		/*
		if (isClient) {
			TransmitPosition ();
			GotoPosition();	
		}
		*/

		Move ();
		limitSpeed ();
	}

	// moves character vertically and handles jumping input
	void Move () {

		if (direction == RIGHT) { // right
			body.AddForce(transform.right * 3);
		} 

		if (direction == LEFT) { // left
			body.AddForce(transform.right * -3);
		}

		if (isLocalPlayer) {
		
		// Player 1 jump
		if (gameObject.tag == "Player" && Input.GetKeyDown (KeyCode.Space)) {
			CmdJump();
			//body.AddForce (new Vector2 (0, 6), ForceMode2D.Impulse);
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

		// increments score when player gets collectables 
		if (coll.gameObject.tag == "collectable") {
			score = score + 100;
			setText();
		}

		// player collision interaction (bounce, switch direction)
		if (coll.gameObject.tag == "Player") {

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

	// sets the score text
	void setText() {

		// Player 1 score text
		if (gameObject.tag == "Player") {
			scoreText.text = "Cat 1: " + score.ToString ();
		} 

		// Player 2 score text
		else if (gameObject.tag == "Player 2") {
			scoreText.text = "Cat 2: " + score.ToString ();
		}
	}


	// limits speed
	void limitSpeed() {
		if(body.velocity.magnitude > maxSpeed) {
			body.velocity = body.velocity.normalized * maxSpeed;
		}
	}

	[Command]
	void CmdJump()
	{
		RpcJump ();
	}
	
	[ClientRpc]
	void RpcJump()
	{
		body.AddForce (new Vector2 (0, 6), ForceMode2D.Impulse);
	}



}
