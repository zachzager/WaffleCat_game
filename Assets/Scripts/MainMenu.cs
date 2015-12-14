// Main Menu
// Attached to Camera
// Sources:
// 		"Unity 2D Tutorial: Main Menu" series and "Unity Tutorial: Main Menu 101 Buttons"
//		  by Brent M (https://www.youtube.com/watch?v=xoaYzfCix3c)


using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle localButton;
	public GUIStyle networkButton;
	public GUIStyle instructionsButton;

	void OnGUI () {

		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

										/* buttons */
		// Local play
		if (GUI.Button (new Rect (Screen.width * .05f, Screen.height * .4f, 
		                          Screen.width * .3f, Screen.height * .25f), "", localButton)) {
			loadLevel(1);
		}

		// Network play
		if (GUI.Button (new Rect (Screen.width * .65f, Screen.height * .4f, 
		                          Screen.width * .3f, Screen.height * .25f), "", networkButton)) {
			Debug.Log("Coming Soon!");
		}

		// Instructions
		if (GUI.Button (new Rect (Screen.width * .435f, Screen.height * .35f, 
		                          Screen.width * .15f, Screen.height * .125f), "", instructionsButton)) {
			loadLevel(7);
		}
	}

	// changes the scene
	void loadLevel (int sceneNumber) {
		Application.LoadLevel (sceneNumber);
	}
}
