using UnityEngine;
using System.Collections;

public class InstructionsMenu : MonoBehaviour {

	public Texture backgroundTexture;
	public GUIStyle backButton;

	void OnGUI () {
		
		// Display background texture
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backgroundTexture);

		// back to main menu
		if (GUI.Button (new Rect (Screen.width * .4f, Screen.height * .885f, 
		                          Screen.width * .2f, Screen.height * .1f), "", backButton)) {
			Application.LoadLevel (0);
		}
	}
}
