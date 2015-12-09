// Character Selection Screen

// Default cat layout:
// normal -> hat -> crazy


using UnityEngine;
using System.Collections;

public class characterMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle normalCat;
	public GUIStyle hatCat;
	public GUIStyle crazyCat;

	public GUIStyle rightArrow;
	public GUIStyle leftArrow;

	int pos = 0;

	void OnGUI () {
		
		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);
		
		/* character buttons */
		characterButtonsDisplayed ();

		// scrolls right through character buttons
		if (GUI.Button (new Rect (Screen.width * .8f, Screen.height * .8f, 
		                          Screen.width * .2f, Screen.height * .25f), "", rightArrow)) {
			pos++;
			if (pos == 3) {
				pos = 0;
			}
		}

		// scrolls left through character buttons
		if (GUI.Button (new Rect (Screen.width * -.01f, Screen.height * .8f, 
		                          Screen.width * .2f, Screen.height * .25f), "", leftArrow)) {
			pos--;
			if (pos == -1) {
				pos = 2;
			}
		}

	}

	// displays character options, scrolls through as player
	// presses right and left arrow buttons
	void characterButtonsDisplayed() {
		if (pos == 0) {
			scenarioZero ();
		} else if (pos == 1) {
			scenarioOne ();
		} else if (pos == 2) {
			scenarioTwo ();
		}
	}

	// first layout [normal -> hat -> crazy]
	void scenarioZero() {
		// normal cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", normalCat)) {
			storePlayerSelection(0);
			loadNextLevel();
		}

		// hat cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .275f, 
		                          Screen.width * .2f, Screen.height * .575f), "", hatCat)) {
			storePlayerSelection(1);
			loadNextLevel();
		}

		// crazy cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", crazyCat)) {
			storePlayerSelection(2);
			loadNextLevel();
		}
	}

	// second layout [crazy -> normal -> hat]
	void scenarioOne() {
		// crazy cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", crazyCat)) {
			storePlayerSelection(2);
			loadNextLevel();
		}

		// normal cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", normalCat)) {
			storePlayerSelection(0);
			loadNextLevel();
		}

		// hat cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .275f, 
		                          Screen.width * .2f, Screen.height * .575f), "", hatCat)) {
			storePlayerSelection(1);
			loadNextLevel();
		}
	}

	// third layout [hat -> crazy -> normal]
	void scenarioTwo() {
		// hat cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .275f, 
		                          Screen.width * .2f, Screen.height * .575f), "", hatCat)) {
			storePlayerSelection(1);
			loadNextLevel();
		}

		// crazy cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", crazyCat)) {
			storePlayerSelection(2);
			loadNextLevel();
		}

		// normal cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", normalCat)) {
			storePlayerSelection(0);
			loadNextLevel();
		}
	}
	
	// sets player selection choice
	void storePlayerSelection (int selection) {
		
		// player 1 selection
		if (Application.loadedLevel == 1) {
			playerChoices.Instance.player1 = selection;
		}
		
		// player 2 selection
		if (Application.loadedLevel == 2) {
			playerChoices.Instance.player2 = selection;
		}
	}
	
	// proceeds to the scene
	void loadNextLevel () {
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	
}

