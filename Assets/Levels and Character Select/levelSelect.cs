// Character Selection Screen


using UnityEngine;
using System.Collections;

public class levelSelect : MonoBehaviour {
	
	public int selectionP1;
	public int selectionP2;
	
	public Texture backgroundTexture;
	public float GUIplacementY;
	public float GUIplacementX;
	public GUIStyle level1;
	public GUIStyle level2;
	public GUIStyle level3;
	
	void OnGUI () {
		
		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);
		
		/* level selection buttons */

		// living room
		if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", level1)) {
			loadNextLevel(4);
		}

		// space
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .275f, 
		                          Screen.width * .2f, Screen.height * .575f), "", level2)) {
			loadNextLevel(5);
		}

		// ocean
		if (GUI.Button (new Rect (Screen.width * .7f, Screen.height * .4f, 
		                          Screen.width * .2f, Screen.height * .45f), "", level3)) {
			loadNextLevel(6);
		}
		
	}
	
	// proceeds to the scene
	void loadNextLevel (int selection) {
		Application.LoadLevel (selection);
	}
	
}

// living room = 4
// space = 5
// ocean = 6