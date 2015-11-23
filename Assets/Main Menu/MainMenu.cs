// Main Menu
// Attached to Camera
// Sources:
// 		"Unity 2D Tutorial: Main Menu" series and "Unity Tutorial: Main Menu 101 Buttons"
//		  by Brent M (https://www.youtube.com/watch?v=xoaYzfCix3c)


using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public float GUIplacementY;
	public float GUIplacementX;
	public GUIStyle startButton;
	//public bool showGUIoutline = true;


	void OnGUI () {

		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

										/* buttons */
		// Play Game
		if (GUI.Button (new Rect (Screen.width * .275f, Screen.height * .4f, 
		                          Screen.width * .45f, Screen.height * .30f), "", startButton)) {
			loadLevel(Application.loadedLevel + 1);
		}

		/*
		// Single Player
		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .625f, 
		                          Screen.width * .5f, Screen.height * .15f), "Single Player")) {
			Debug.Log ("Clicked Single Player");
		}

		// Settings
		if (GUI.Button (new Rect (Screen.width * .25f, Screen.height * .8f, 
		                          Screen.width * .5f, Screen.height * .15f), "Settings")) {
			Debug.Log ("Clicked Settings");
		}
		*/
	}

	// changes the scene
	void loadLevel (int sceneNumber) {
		Application.LoadLevel (sceneNumber);
	}

}
