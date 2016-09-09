using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{

	public GameObject m_enemyPrefab;
	public float m_width = 16f;
	public float m_height = 9f;
	public float m_speed = 5f;
	private bool m_movingRight = false;
	private float m_maxX;
	private float m_minX;

	// Use this for initialization
	void Start ()
	{
		float distanceToCamera = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftBoundary = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceToCamera));
		Vector3 rightBoundary = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distanceToCamera));

		m_minX = leftBoundary.x;
		m_maxX = rightBoundary.x;

		SpawnFormation ();
	}

	public void OnDrawGizmos ()
	{
		Gizmos.DrawWireCube (transform.position, new Vector3 (m_width, m_height));
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (m_movingRight) {
			transform.position += Vector3.right * m_speed * Time.deltaTime;
			float formationRightEdge = transform.position.x + (0.5f * m_width);
			if (formationRightEdge > m_maxX) {
				m_movingRight = false;
			}
		} else {
			transform.position += Vector3.left * m_speed * Time.deltaTime;
			float formationLeftEdge = transform.position.x - (0.5f * m_width);
			if (formationLeftEdge < m_minX) {
				m_movingRight = true;
			}
		}

		if (AllMembersDead ()) {
			Debug.Log ("Empty Formation");
			SpawnFormation ();
		}
	}

	bool AllMembersDead ()
	{
		foreach (Transform childPositionGameOjbect in transform) {
			if (childPositionGameOjbect.childCount != 0) {
				return false;
			}
		}
		return true;
	}

	void SpawnFormation ()
	{
		foreach (Transform child in transform) {
			GameObject enemy = Instantiate (m_enemyPrefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
		}
	}
}
