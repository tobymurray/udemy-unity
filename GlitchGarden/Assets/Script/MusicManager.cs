using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{

	public AudioClip[] m_levelMusicChangeArray;
	private AudioSource m_audioSource;

	void Awake()
	{
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);
	}

	// Use this for initialization
	void Start ()
	{
		m_audioSource = GetComponent<AudioSource> ();
	}

	void OnLevelWasLoaded(int level)
	{
		AudioClip levelMusic = m_levelMusicChangeArray [level];
		if (levelMusic) {
			Debug.Log ("Playing clip: " + levelMusic);
			m_audioSource.clip = levelMusic;
			m_audioSource.loop = true;
			m_audioSource.Play();
		} else {
			Debug.Log ("No level music configured for level " + level);
		}
	}
		
	// Update is called once per frame
	void Update ()
	{
	
	}
}
