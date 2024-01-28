using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSinglePlayer : MonoBehaviour {
	public Font f;

	void OnGUI(){
		GUI.contentColor = Color.black;
		GUI.skin.label.fontSize = 18;
		GUI.Label (new Rect (Screen.width / 2 - 575, 50, 1100, 1000), "There is a group of seemingly normal friends, but they all share the same interest; the interest to fight.  " +
			"Each day they get together to hold intense fighting competitions with each other, and today is your first time participating.");

		GUI.Label (new Rect (Screen.width / 2 - 575, 200, 1100, 1000), "You are Josh, the newest friend of the FFG, the Friend Fighting Gang.  " +
			"You got a lot of heart and you want to prove you strength as a friend.  But hey, it's okay if you lose, you are still their friend.");

		GUI.contentColor = Color.white;
		if(GUI.Button (new Rect (Screen.width / 2 - 100, 500, 175, 40), "FRIEND!")){
			Application.LoadLevel ("Level 1");
		}
		if(GUI.Button (new Rect (Screen.width / 4 - 100, 500, 175, 40), "Back")){
			Application.LoadLevel ("MainMenu");
		}	


	}
}
