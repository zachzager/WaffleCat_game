using UnityEngine;
using System.Collections;

public class keepInBounds : MonoBehaviour {

	void Update () {

		returnToBounds ();
	}

	void returnToBounds() {
		if (gameObject.transform.position.y < -11) {
			gameObject.transform.position = new Vector3(-6,1);
		}
	}
}
