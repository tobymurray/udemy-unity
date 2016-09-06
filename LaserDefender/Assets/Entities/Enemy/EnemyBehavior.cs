using UnityEngine;
using System.Collections;

public class EnemyBehavior : MonoBehaviour {

	public float m_health;
	
	void OnTriggerEnter2D(Collider2D collider) {
		Projectile projectile = collider.gameObject.GetComponent<Projectile> ();
		if (projectile) {
			m_health -= projectile.GetDamage();
			projectile.Hit ();

			if (m_health <= 0) {
				Destroy(gameObject);
			}
		}
	}
}
