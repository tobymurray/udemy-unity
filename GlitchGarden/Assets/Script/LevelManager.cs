using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{
	public float m_autoLoadNextLevelAfter;

	void Start ()
	{
		Invoke ("LoadNextLevel", m_autoLoadNextLevelAfter);
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
		Application.LoadLevel (Application.loadedLevel + 1);
	}

}
