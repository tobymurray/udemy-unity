using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	private static MusicPlayer s_instance;

	void Awake () {
		if (s_instance != null) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			s_instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
