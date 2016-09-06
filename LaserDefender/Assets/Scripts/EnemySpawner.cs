using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject m_enemyPrefab;

	// Use this for initialization
	void Start () {
		GameObject enemy = Instantiate (m_enemyPrefab, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		enemy.transform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
