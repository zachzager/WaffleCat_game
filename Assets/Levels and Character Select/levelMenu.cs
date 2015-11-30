// Character Selection Screen


using UnityEngine;
using System.Collections;

public class levelMenu : MonoBehaviour {
	
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
		if (GUI.Button (new Rect (Screen.width * .025f, Screen.height * .35f, 
		                          Screen.width * .3f, Screen.height * .5f), "", level1)) {
			loadNextLevel(4);
		}

		// space
		if (GUI.Button (new Rect (Screen.width * .35f, Screen.height * .35f, 
		                          Screen.width * .3f, Screen.height * .5f), "", level2)) {
			loadNextLevel(5);
		}

		// ocean
		if (GUI.Button (new Rect (Screen.width * .675f, Screen.height * .35f, 
		                          Screen.width * .3f, Screen.height * .5f), "", level3)) {
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