using UnityEngine;
using System.Collections;

public class respawnOnCollision : MonoBehaviour {

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
	void OnTriggerEnter2D(Collider2D coll) {

		Vector2 randCoordinates;
		
		do {
			randCoordinates.x = Random.Range (-18,18);
			randCoordinates.y = Random.Range (-8,9);
		} while(Physics2D.OverlapCircle(randCoordinates,2));
		
		gameObject.transform.position = new Vector3(randCoordinates.x,randCoordinates.y);
	}


	// limits speed to zero
	void limitSpeed() {
		if(body.velocity.magnitude > maxSpeed) {
			body.velocity = body.velocity.normalized * maxSpeed;
		}
	}

}