using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class keepInBounds : NetworkBehaviour {

	void Update () {

		returnToBounds ();
	}

	void returnToBounds() {
		if (gameObject.transform.position.y < -11) {
			gameObject.transform.position = new Vector3(-6,1);
		}
	}
}
