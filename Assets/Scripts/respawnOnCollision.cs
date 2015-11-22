using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class respawnOnCollision : NetworkBehaviour {

	private Rigidbody2D body;
	private float maxSpeed;

	// Use this for initialization
	void Start () {
		body = GetComponent <Rigidbody2D> ();
		maxSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () {
		limitSpeed ();
	}

	// detects collisions with 
	//	1. players (cats) to respawn objects
	//  2. walls/platforms to prevent spawning on them
	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.gameObject.tag == "Player") {
			gameObject.transform.position = new Vector3(Random.Range (-14,14),Random.Range (-5,7));
		}

		if (coll.gameObject.tag == "Wall" || 
		    	coll.gameObject.tag =="platform" || 
		    		coll.gameObject.tag =="platform") {

			/*
			Vector2 randCoordinates;

			do {
				randCoordinates.x  = Random.Range (-18,18);
				randCoordinates.y = Random.Range (-8,9);
			} while(Physics2D.OverlapCircle(randCoordinates,20));

			gameObject.transform.position = new Vector3(randCoordinates.x,randCoordinates.y);
			*/
			gameObject.transform.position = new Vector3(Random.Range (-18,18),Random.Range (-8,9));
		}
	}

	// limits speed to zero
	void limitSpeed() {
		if(body.velocity.magnitude > maxSpeed) {
			body.velocity = body.velocity.normalized * maxSpeed;
		}
	}

}