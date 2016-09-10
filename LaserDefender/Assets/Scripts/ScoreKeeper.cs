using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{
	private int m_score;
	private Text m_text;

	void Start ()
	{
		m_text = GetComponent<Text> ();
		Reset ();
	}

	public void Score (int points)
	{
		m_score += points;
		m_text.text = m_score.ToString ();
	}

	public void Reset ()
	{
		m_score = 0;
		m_text.text = m_score.ToString ();
	}
}
