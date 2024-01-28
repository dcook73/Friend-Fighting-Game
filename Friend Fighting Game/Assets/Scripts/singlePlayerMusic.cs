using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singlePlayerMusic : MonoBehaviour {
	private static singlePlayerMusic instance = null;
	public static singlePlayerMusic Instance
	{
		get {return instance; }	
	}

	void Awake(){
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else
			instance = this;

		DontDestroyOnLoad (this.gameObject);
	}

	void Update(){
		if (Application.loadedLevelName == "Knuckles") {
			Destroy (this.gameObject);
		}
		if (Application.loadedLevelName == "MainMenu") {
			Destroy (this.gameObject);
		}
	}
}
