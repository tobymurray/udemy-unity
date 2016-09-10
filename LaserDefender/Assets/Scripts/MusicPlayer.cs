using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	public AudioClip m_startClip;
	public AudioClip m_gameClip;
	public AudioClip m_endClip;
	static MusicPlayer instance = null;
	private AudioSource m_music;
	
	void Start () {
		if (instance != null && instance != this) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
			m_music = GetComponent<AudioSource>();
			m_music.clip = m_startClip;
			m_music.loop = true;
			m_music.Play();
		}
	}

	void OnLevelWasLoaded(int level)
	{
		m_music.Stop ();
		Debug.Log("MusicPlayer: Loaded level " + level);

		AudioClip levelMusic;
		switch (level) {
		case 0:
			levelMusic = m_startClip;
			break;
		case 1:
			levelMusic = m_gameClip;
			break;
		case 2:
			levelMusic = m_endClip;
			break;
		default:
			Debug.Log("No music assigned for level " + level);
			return;
		}
		m_music.clip = levelMusic;
		m_music.loop = true;
		m_music.Play();
	}
}
