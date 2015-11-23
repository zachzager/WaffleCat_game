using UnityEngine;
using System.Collections;

public class playerChoices : MonoBehaviour {

	public static playerChoices Instance = null;

	public int player1;
	public int player2;
	
	void Awake() {

		DontDestroyOnLoad(this.gameObject);

		if (Instance == null) {
			Instance = this;
		} else if(Instance != this) {
			Destroy(this.gameObject);
		}
	}
}

// EXAMPLES
// read chosen gun
//int chosen_gun = playerChoices.Intance.gun;

//save chosen gun
//playerChoices.Intance.gun = PlayerGuns.Knife;