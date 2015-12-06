using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int m_maxHits;
	private int m_timesHit;

	// Use this for initialization
	void Start () {
		m_timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		m_timesHit++;
		print (m_timesHit);
	}
}
