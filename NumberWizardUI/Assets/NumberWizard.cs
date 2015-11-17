using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int m_min;
	int m_max;
	int m_guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		m_min = 1;
		m_max = 1000;
		m_guess = (m_min + m_max) / 2;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		print ("The lowest number you can pick is " + m_min);
		print ("The highest number you can pick is " + m_max);
		print ("Is the number higher or lower than " + m_guess + "?");
		print ("Up = higher, down = lower, return = equal");

		m_max = m_max + 1;
	}

	void NextGuess() {
		m_guess = (m_max + m_min) / 2;
		print ("Higher or lower than " + m_guess + "?");
		print ("Up = higher, down = lower, return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			m_min = m_guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			m_max = m_guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame();
		}
	}
}
