using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public float m_autoLoadNextLevelAfter;

	void Start ()
	{
		if (m_autoLoadNextLevelAfter < 0) {
			throw new UnityException ("Auto Load Next Level After value must be >= 0, but was " + m_autoLoadNextLevelAfter);
		}
		if (m_autoLoadNextLevelAfter != 0) {
			Invoke ("LoadNextLevel", m_autoLoadNextLevelAfter);
		}
		
	}

	public void LoadLevel (string name)
	{
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest ()
	{
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void LoadNextLevel ()
	{
		Application.LoadLevel (+ 1);
	}

}
