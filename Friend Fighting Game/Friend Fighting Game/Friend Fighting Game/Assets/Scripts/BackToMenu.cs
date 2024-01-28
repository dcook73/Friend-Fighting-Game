using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour {

	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width / 2 + 400, 580, 175, 40), "Main Menu"))
			SceneManager.LoadScene ("MainMenu");
	}
}
