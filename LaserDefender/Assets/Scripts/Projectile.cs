using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
	
	public float m_damage = 100f;
	
	public void Hit ()
	{
		Destroy (gameObject);
	}

	public float GetDamage ()
	{
		return m_damage;
	}
}
