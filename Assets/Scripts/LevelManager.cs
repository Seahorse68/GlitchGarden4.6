﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

public float autoLoadNextLevelAfter;

	void Start() {
		if (autoLoadNextLevelAfter <= 0) {
			Debug.Log ("Level auto load disabled, use a positive number of seconds");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name) {
		Debug.Log ("Level Load requested for: " + name);
		Application.LoadLevel (name);
	}
	
	public void QuitRequest() {
		Debug.Log ("Quit Requested");
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
