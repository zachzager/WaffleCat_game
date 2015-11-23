// CharacterSelection.cs
// Made using "Character Selection [Tutorial][C#] - Unity 3d" by YouTube user N3K EN
// (https://www.youtube.com/watch?v=T-AbCUuLViA)
//

// Uses inputted data to select character for players

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterSelection : MonoBehaviour {
	
	private List<GameObject> models;
	private int selectionIndex = 0; // default selection index

	// Use this for initialization
	void Start () {

		Debug.Log (playerChoices.Instance.player1);
		Debug.Log (playerChoices.Instance.player2);
		Debug.Log (gameObject.tag);

		models = new List<GameObject>();

		foreach(Transform t in transform) {
			models.Add(t.gameObject);
			t.gameObject.SetActive (false);
		}

		models[selectionIndex].SetActive(true);

		selectCharacter ();
	}

	// checks for character choice (/user input for now)
	void Update () {
		/* if (Input.GetKeyDown (KeyCode.Z)) {
			Select (0);
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			Select (1);
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			Select (2);
		} */
	}

	// selects player model from list of characters
	void selectCharacter () {

		// Player 1
		if (gameObject.tag == "Player 1") {
			setCharacter (playerChoices.Instance.player1);
		}

		// Player 2
		if (gameObject.tag == "Player 2") {
			setCharacter (playerChoices.Instance.player2);
		}

	}

	// sets the character from the list
	void setCharacter(int index) {

		if (index == selectionIndex) {
			return;
		}

		if (index < 0 || index >= models.Count) {
			return;
		}
	
		models [selectionIndex].SetActive (false);
		selectionIndex = index;
		models [selectionIndex].SetActive (true);
	}
}
