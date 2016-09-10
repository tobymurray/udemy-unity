using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{
	public AudioClip m_deathSound;
	public AudioClip m_projectileSound;
	public float m_health;
	public GameObject m_projectile;
	public float m_projectileSpeed;
	public float m_shotsPerSecond;
	public int m_scoreValue = 150;
	private ScoreKeeper m_scoreKeeper;

	void Start ()
	{
		m_scoreKeeper = GameObject.Find ("Score").GetComponent<ScoreKeeper> ();
	}

	// Update is called once per frame
	void Update ()
	{
		float probability = Time.deltaTime * m_shotsPerSecond;
		if (Random.value < probability) {
			Fire ();
		}
	}
	
	void OnTriggerEnter2D (Collider2D collider)
	{
		Projectile projectile = collider.gameObject.GetComponent<Projectile> ();
		if (projectile) {
			m_health -= projectile.GetDamage ();
			projectile.Hit ();

			if (m_health <= 0) {
				Die ();
			}
		}
	}

	void Die ()
	{
		AudioSource.PlayClipAtPoint (m_deathSound, transform.position);
		Destroy (gameObject);
		m_scoreKeeper.Score (m_scoreValue);
	}
	
	void Fire ()
	{
		GameObject projectile = Instantiate (m_projectile, transform.position, Quaternion.identity) as GameObject;
		projectile.rigidbody2D.velocity = Vector3.down * m_projectileSpeed;
		AudioSource.PlayClipAtPoint (m_projectileSound, transform.position);
	}
}
