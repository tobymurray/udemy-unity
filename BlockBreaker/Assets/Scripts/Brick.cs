using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int m_maxHits;
	private int m_timesHit;
	private LevelManager m_levelManager;

	// Use this for initialization
	void Start () {
		m_timesHit = 0;
		m_levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		m_timesHit++;
		print (m_timesHit);
		SimulateWin ();
	}

	// TODO Remove this method once we can actually win
	void SimulateWin() {
		m_levelManager.LoadNextLevel ();
	}
}
