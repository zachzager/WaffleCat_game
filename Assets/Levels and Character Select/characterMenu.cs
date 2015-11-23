// Character Selection Screen


using UnityEngine;
using System.Collections;

public class characterMenu : MonoBehaviour {
	
	public int selectionP1;
	public int selectionP2;

	public Texture backgroundTexture;
	public float GUIplacementY;
	public float GUIplacementX;
	public GUIStyle cat1;
	public GUIStyle cat2;
	public GUIStyle cat3;
	
	void OnGUI () {
		
		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);
		
		/* character buttons */
		
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", cat1)) {
			storePlayerSelection(0);
			loadNextLevel();
		}
		
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .275f, 
		                          Screen.width * .2f, Screen.height * .575f), "", cat2)) {
			storePlayerSelection(1);
			loadNextLevel();
		}
		
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", cat3)) {
			storePlayerSelection(2);
			loadNextLevel();
		}
		
	}
	
	// sets player selection choice a
	void storePlayerSelection (int selection) {
		
		// player 1 selection
		if (Application.loadedLevel == 1) {
			selectionP1 = selection;
			playerChoices.Instance.player1 = selection;
		}
		
		// player 2 selection
		if (Application.loadedLevel == 2) {
			selectionP2 = selection;
			playerChoices.Instance.player2 = selection;
		}
	}
	
	// proceeds to the scene
	void loadNextLevel () {
		Application.LoadLevel (Application.loadedLevel + 1);
	}
	
}

