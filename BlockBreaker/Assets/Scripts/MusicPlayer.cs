using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	private static MusicPlayer s_instance;

	// Use this for initialization
	void Start () {
		if (s_instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			s_instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
