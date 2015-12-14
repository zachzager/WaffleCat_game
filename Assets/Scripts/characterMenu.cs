// Character Selection Screen

// Default cat layout:
// normal -> hat -> crazy -> astro -> santa -> tufts -> nyan -> hippie


using UnityEngine;
using System.Collections;

public class characterMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle chooseCatText;
	public GUIStyle playerNum;

	// cat button images
	public GUIStyle normalCat;
	public GUIStyle hatCat;
	public GUIStyle crazyCat;
	public GUIStyle astroCat;
	public GUIStyle santaCat;
	public GUIStyle tuftsCat;
	public GUIStyle nyanCat;
	public GUIStyle hippieCat;

	public GUIStyle rightArrow;
	public GUIStyle leftArrow;

	int pos = 1;

	void OnGUI () {

		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		// Show "Choose your cat" text
		GUI.Button(new Rect(Screen.width * .1f, Screen.height * .05f,
		                   Screen.width * .8f, Screen.height * .175f),"",chooseCatText);

		// Show "Player X" text
		GUI.Button(new Rect(Screen.width * .3f, Screen.height * .865f,
		                    Screen.width * .4f, Screen.height * .125f),"",playerNum);
		
		/* character buttons */
		characterButtonsDisplayed ();

		// scrolls right through character buttons
		if (GUI.Button (new Rect (Screen.width * .8f, Screen.height * .79f, 
		                          Screen.width * .2f, Screen.height * .25f), "", rightArrow)) {
			pos++;
			if (pos == 9) {
				pos = 1;
			}
		}

		// scrolls left through character buttons
		if (GUI.Button (new Rect (Screen.width * -.01f, Screen.height * .78f, 
		                          Screen.width * .2f, Screen.height * .25f), "", leftArrow)) {
			pos--;
			if (pos == 0) {
				pos = 8;
			}
		}

	}

	// displays character options, scrolls through as player
	// presses right and left arrow buttons
	void characterButtonsDisplayed() {
		if (pos == 1) {
			scenarioOne ();
		} else if (pos == 2) {
			scenarioTwo ();
		} else if (pos == 3) {
			scenarioThree ();
		} else if (pos == 4) {
			scenarioFour ();
		} else if (pos == 5) {
			scenarioFive ();
		} else if (pos == 6) {
			scenarioSix ();
		} else if (pos == 7) {
			scenarioSeven ();
		} else if (pos == 8) {
			scenarioEight ();
		}
	}

	// first layout [normal -> hat -> crazy]
	void scenarioOne() {
		// normal cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", normalCat)) {
			storePlayerSelection(0);
			loadNextLevel();
		}

		// hat cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .26f,
		                          Screen.width * .2f, Screen.height * .6f), "", hatCat)) {
			storePlayerSelection(1);
			loadNextLevel();
		}

		// crazy cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", crazyCat)) {
			storePlayerSelection(2);
			loadNextLevel();
		}
	}

	// second layout [hat -> crazy -> astro]
	void scenarioTwo() {
		// hat cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .26f, 
		                          Screen.width * .2f, Screen.height * .6f), "", hatCat)) {
			storePlayerSelection(2);
			loadNextLevel();
		}

		// crazy cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", crazyCat)) {
			storePlayerSelection(1);
			loadNextLevel();
		}

		// astro cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .325f, 
		                          Screen.width * .2f, Screen.height * .55f), "", astroCat)) {
			storePlayerSelection(2);
			loadNextLevel();
		}
	}

	// third layout [crazy -> astro -> santa]
	void scenarioThree() {
		// crazy cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", crazyCat)){
			storePlayerSelection(2);
			loadNextLevel();
		}

		// astro cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .325f, 
		                          Screen.width * .2f, Screen.height * .55f), "", astroCat)) {
			storePlayerSelection(3);
			loadNextLevel();
		}

		// santa cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .375f, 
		                          Screen.width * .2f, Screen.height * .475f), "", santaCat)) {
			storePlayerSelection(4);
			loadNextLevel();
		}
	}
	

	// fourth layout [astro -> santa -> tufts]
	void scenarioFour() {
		// astro cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .325f, 
		                          Screen.width * .2f, Screen.height * .55f), "", astroCat)) {
			storePlayerSelection(3);
			loadNextLevel();
		}
		
		// santa cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .375f, 
		                          Screen.width * .2f, Screen.height * .475f), "", santaCat)) {
			storePlayerSelection(4);
			loadNextLevel();
		}

		// tufts cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .375f, 
		                          Screen.width * .2f, Screen.height * .475f), "", tuftsCat)) {
			storePlayerSelection(4);
			loadNextLevel();
		}
	}
	
	// // fourth layout [santa -> tufts -> nyan]
	void scenarioFive() {
		// santa cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .375f, 
		                          Screen.width * .2f, Screen.height * .475f), "", santaCat)) {
			storePlayerSelection(4);
			loadNextLevel();
		}

		// tufts cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .375f, 
		                          Screen.width * .2f, Screen.height * .475f), "", tuftsCat)) {
			storePlayerSelection(5);
			loadNextLevel();
		}

		// nyan cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .35f, 
		                          Screen.width * .225f, Screen.height * .5f), "", nyanCat)) {
			storePlayerSelection(6);
			loadNextLevel();
		}
	}

	// sixth layout [tufts -> nyan -> hippie] 
	void scenarioSix() {

		// tufts cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .375f, 
		                          Screen.width * .2f, Screen.height * .475f), "", tuftsCat)) {
			storePlayerSelection(5);
			loadNextLevel();
		}

		// nyan cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .35f, 
		                          Screen.width * .225f, Screen.height * .5f), "", nyanCat)) {
			storePlayerSelection(6);
			loadNextLevel();
		}

		// hippie cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", hippieCat)) {
			storePlayerSelection(7);
			loadNextLevel();
		}

	}

	// sixth layout [nyan -> hippie -> normal]
	void scenarioSeven() {
		// nyan cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .35f, 
		                          Screen.width * .225f, Screen.height * .5f), "", nyanCat)) {
			storePlayerSelection(6);
			loadNextLevel();
		}
		
		// hippie cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", hippieCat)) {
			storePlayerSelection(7);
			loadNextLevel();
		}
		
		// normal cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", normalCat)) {
			storePlayerSelection(0);
			loadNextLevel();
		}
	}

	// seventh layout [hippie -> normal -> hat]
	void scenarioEight() {
		// hippie cat
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", hippieCat)) {
			storePlayerSelection(7);
			loadNextLevel();
		}
		
		// normal cat
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .35f, 
		                          Screen.width * .2f, Screen.height * .5f), "", normalCat)) {
			storePlayerSelection(0);
			loadNextLevel();
		}
		
		// hat cat
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .26f, 
		                          Screen.width * .2f, Screen.height * .6f), "", hatCat)) {
			storePlayerSelection(1);
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

