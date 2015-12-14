// playerChoices.cs
// Made using "Character Selection [Tutorial][C#] - Unity 3d" by YouTube user N3K EN
// (https://www.youtube.com/watch?v=T-AbCUuLViA)
//

// stores player character choices

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
