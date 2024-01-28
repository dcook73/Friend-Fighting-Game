using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuMusic : MonoBehaviour {
	private static menuMusic instance = null;
	public static menuMusic Instance
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
		if (Application.loadedLevelName == "Level 1") {
			Destroy (this.gameObject);
		}
		if (Application.loadedLevelName == "Level 2") {
			Destroy (this.gameObject);
		}
		if (Application.loadedLevelName == "PlayerSelect") {
			Destroy (this.gameObject);
		}
	}
}
