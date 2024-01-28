using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour {
	public Font f;
	Color initialTitle = Color.red;
	Color otherTitle = Color.blue;
	Color buttonColor = Color.white;

	void OnGUI(){
		GUI.skin.font = f;

		GUI.skin.label.fontSize = 40;
		GUI.contentColor = initialTitle;
		GUI.Label (new Rect (Screen.width / 2 - 530, 50, 2000, 1000), "Player 1");

		GUI.skin.label.fontSize = 40;
		GUI.contentColor = otherTitle;
		GUI.Label (new Rect (Screen.width / 2 + 170, 50, 2000, 1000), "Player 2");

		GUI.skin.label.fontSize = 23;
		GUI.contentColor = initialTitle;
		GUI.Label (new Rect (Screen.width / 2 - 570, 150, 2000, 1000), "W: Jump");
		GUI.Label (new Rect (Screen.width / 2 - 570, 190, 2000, 1000), "A: Move character left");
		GUI.Label (new Rect (Screen.width / 2 - 570, 230, 2000, 1000), "D: Move character right");
		GUI.Label (new Rect (Screen.width / 2 - 570, 270, 2000, 1000), "R: Punch");
		GUI.Label (new Rect (Screen.width / 2 - 570, 310, 2000, 1000), "F: Kick");
		GUI.Label (new Rect (Screen.width / 2 - 570, 350, 2000, 1000), "S: Block");
		GUI.Label (new Rect (Screen.width / 2 - 570, 390, 2000, 1000), "Q: Special Ability");

		GUI.skin.label.fontSize = 23;
		GUI.contentColor = otherTitle;
		GUI.Label (new Rect (Screen.width / 2 + 90, 150, 2000, 1000), "I: Jump");
		GUI.Label (new Rect (Screen.width / 2 + 90, 190, 2000, 1000), "J: Move character left");
		GUI.Label (new Rect (Screen.width / 2 + 90, 230, 2000, 1000), "L: Move character right");
		GUI.Label (new Rect (Screen.width / 2 + 90, 270, 2000, 1000), "Y: Punch");
		GUI.Label (new Rect (Screen.width / 2 + 90, 310, 2000, 1000), "H: Kick");
		GUI.Label (new Rect (Screen.width / 2 + 90, 350, 2000, 1000), "K: Block");
		GUI.Label (new Rect (Screen.width / 2 + 90, 390, 2000, 1000), "P: Special Ability");

		GUI.skin.button.fontSize = 12;
		GUI.contentColor = buttonColor;
		if (GUI.Button (new Rect (Screen.width / 2 - 100, 500, 175, 40), "Back")){
			Application.LoadLevel ("MainMenu");
		}
	}
}
