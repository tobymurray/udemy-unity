using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour
{

	public float m_health;
	public GameObject m_projectile;
	public float m_projectileSpeed;
	public float m_shotsPerSecond;

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
				Destroy (gameObject);
			}
		}
	}

	void Fire ()
	{
		Vector3 startPosition = new Vector3 (transform.position.x, transform.position.y - 1);
		GameObject projectile = Instantiate (m_projectile, startPosition, Quaternion.identity) as GameObject;
		projectile.rigidbody2D.velocity = Vector3.down * m_projectileSpeed;
	}
}
