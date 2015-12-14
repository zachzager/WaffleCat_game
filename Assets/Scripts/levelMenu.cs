// Level Selection Screen

using UnityEngine;
using System.Collections;

public class levelMenu : MonoBehaviour {
	
	public Texture backgroundTexture;
	public GUIStyle chooseLevelText;
	public GUIStyle livingRoomButton;
	public GUIStyle livingRoomText;
	public GUIStyle spaceButton;
	public GUIStyle spaceText;
	public GUIStyle oceanButton;
	public GUIStyle oceanText;
	
	void OnGUI () {
		
		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		// Show "Choose your level" text
		GUI.Button(new Rect(Screen.width * .1f, Screen.height * .05f,
		                    Screen.width * .8f, Screen.height * .175f),"",chooseLevelText);
		
		/* level selection buttons */

		// living room
		if (GUI.Button (new Rect (Screen.width * .025f, Screen.height * .325f, 
		                          Screen.width * .3f, Screen.height * .4f), "", livingRoomButton)) {
			loadNextLevel(4);
		}

		// space
		if (GUI.Button (new Rect (Screen.width * .35f, Screen.height * .325f, 
		                          Screen.width * .3f, Screen.height * .4f), "", spaceButton)) {
			loadNextLevel(5);
		}

		// ocean
		if (GUI.Button (new Rect (Screen.width * .675f, Screen.height * .325f, 
		                          Screen.width * .3f, Screen.height * .4f), "", oceanButton)) {
			loadNextLevel(6);
		}

		/* level selection text */

		// living room
		GUI.Button (new Rect (Screen.width * .025f, Screen.height * .72f, 
		                      Screen.width * .3f, Screen.height * .25f), "", livingRoomText);

		// space
		GUI.Button (new Rect (Screen.width * .35f, Screen.height * .72f, 
                              Screen.width * .3f, Screen.height * .25f), "", spaceText);

		// ocean
        GUI.Button (new Rect (Screen.width * .675f, Screen.height * .72f, 
		                      Screen.width * .3f, Screen.height * .25f), "", oceanText);
	}
	
	// proceeds to the scene
	void loadNextLevel (int selection) {
		Application.LoadLevel (selection);
	}
	
}

// living room = 4
// space = 5
// ocean = 6