using UnityEngine;
using System.Collections;

public class LoseColliderScript : MonoBehaviour {

	public LevelManager m_levelManager;

	void OnTriggerEnter2D(Collider2D trigger) {
		print ("Trigger");
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		print ("Collision");
		m_levelManager.LoadLevel ("Win");
	}
}
