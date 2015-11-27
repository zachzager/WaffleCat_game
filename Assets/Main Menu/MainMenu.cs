// Main Menu
// Attached to Camera
// Sources:
// 		"Unity 2D Tutorial: Main Menu" series and "Unity Tutorial: Main Menu 101 Buttons"
//		  by Brent M (https://www.youtube.com/watch?v=xoaYzfCix3c)


using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public Texture logo;
	public GUIStyle startButton;

	void OnGUI () {

		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		// Logo
		GUI.DrawTexture (new Rect (Screen.width * .2f, Screen.height * .025f, 
		                         Screen.width * .6f, Screen.height * .6f), logo);

										/* buttons */
		// Play Game
		if (GUI.Button (new Rect (Screen.width * .3f, Screen.height * .7f, 
		                          Screen.width * .4f, Screen.height * .25f), "", startButton)) {
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
