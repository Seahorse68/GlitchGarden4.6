using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

public float autoLoadNextLevelAfter;

	void Start() {
		Invoke ("LoadNextLevel", autoLoadNextLevelAfter);
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
