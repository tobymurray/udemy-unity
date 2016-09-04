using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("Level load requested for: " + name);
		Brick.s_breakableCount = 0;
		Application.LoadLevel (name);
	}

	public void QuitRequested() {
		Debug.Log ("I want to quit!");
		Application.Quit ();
	}

	public void LoadNextLevel() {
		Brick.s_breakableCount = 0;
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void BrickDestroyed() {
		if (Brick.s_breakableCount <= 0) {
			LoadNextLevel();
		}
	}

}
