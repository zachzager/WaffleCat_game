// Character Selection Screen

// Based on "Unity Tower Defense Tutorial Part 5: 
// Passing data between scenes and Main Menus" by Final Parsec
// (https://www.youtube.com/watch?v=KYADPkNTEHM)


using UnityEngine;
using System.Collections;

public class playerCharacterChoices {
	
	public int selectionP1;
	public int selectionP2;

	public playerCharacterChoices(int selectionP1, int selectionP2) {
		this.selectionP1 = selectionP1;
		this.selectionP2 = selectionP2;
	}

}

