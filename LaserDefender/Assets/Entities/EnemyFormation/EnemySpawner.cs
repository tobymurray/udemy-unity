using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject m_enemyPrefab;

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			GameObject enemy = Instantiate (m_enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
