using UnityEngine;
using System.Collections;

public class LoseColliderScript : MonoBehaviour {

	private LevelManager m_levelManager;

	void Start() {
		m_levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D trigger) {
		print ("Trigger");
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		print ("Collision");
		m_levelManager.LoadLevel ("Win");
	}
}
