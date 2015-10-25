using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");

		int min = 1;
		int max = 1000;

		print ("The lowest number you can pick is " + min);
		print ("The highest number you can pick is " + max);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
