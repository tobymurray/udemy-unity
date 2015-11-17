using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	public int m_maxGuesses = 10;
	int m_min;
	int m_max;
	int m_guess;
	int m_numGuesses = 0;

	public Text m_text;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	void StartGame() {
		m_min = 1;
		m_max = 1000;
		m_guess = (m_min + m_max) / 2;
		m_max = m_max + 1;
	}

	void NextGuess() {
		m_guess = (m_max + m_min) / 2;
		m_text.text = m_guess.ToString();
		m_numGuesses += 1;
		if (m_numGuesses >= m_maxGuesses) {
			Application.LoadLevel("Win");
		}
	}

	public void GuessHigher() {
		m_min = m_guess;
		NextGuess();
	}

	public void GuessLower() {
		m_max = m_guess;
		NextGuess();
	}
}
