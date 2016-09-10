using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{
	private static int s_score;
	private Text m_text;

	void Start ()
	{
		s_score = 0;
		m_text = GetComponent<Text> ();
		m_text.text = s_score.ToString ();
	}

	public void Score (int points)
	{
		s_score += points;
		m_text.text = s_score.ToString ();
	}

	public static int get ()
	{
		return s_score;
	}

	public static void Reset ()
	{
		s_score = 0;
	}
}
