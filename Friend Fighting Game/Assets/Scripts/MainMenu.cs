using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
	public Font f;
	Color initialTitle = Color.red;
	Color otherTitle = Color.white;
	Color buttonColor = Color.white;

	void OnGUI(){
		GUI.skin.font = f;

		GUI.skin.label.fontSize = 100;
		GUI.contentColor = initialTitle;
		GUI.Label (new Rect (Screen.width / 2 - 530, 50, 2000, 1000), "F");

		GUI.skin.label.fontSize = 50;
		GUI.contentColor = otherTitle;
		GUI.Label (new Rect (Screen.width / 2 - 470, 95, 2000, 1000), "riend");

		GUI.skin.label.fontSize = 100;
		GUI.contentColor = initialTitle;
		GUI.Label (new Rect (Screen.width / 2 - 200, 50, 2000, 1000), "F");

		GUI.skin.label.fontSize = 50;
		GUI.contentColor = otherTitle;
		GUI.Label (new Rect (Screen.width / 2 - 140, 95, 2000, 1000), "ighting");

		GUI.skin.label.fontSize = 100;
		GUI.contentColor = initialTitle;
		GUI.Label (new Rect (Screen.width / 2 + 220, 50, 2000, 1000), "G");

		GUI.skin.label.fontSize = 50;
		GUI.contentColor = otherTitle;
		GUI.Label (new Rect (Screen.width / 2 + 320, 95, 2000, 1000), "ame");

		GUI.skin.button.fontSize = 12;
		GUI.contentColor = buttonColor;
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 175, 40), "1 Player")){
			Application.LoadLevel ("startSinglePlayer");
		}

		GUI.skin.button.fontSize = 12;
		GUI.contentColor = buttonColor;
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 175, 40), "2 Players")){
			//	Application.LoadLevel ("level 1");
			Application.LoadLevel("PlayerSelect");
		}

		GUI.skin.button.fontSize = 12;
		GUI.contentColor = buttonColor;
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height / 2, 175, 40), "How To Play")){
			Application.LoadLevel ("How To Play");
		}
	}
}
