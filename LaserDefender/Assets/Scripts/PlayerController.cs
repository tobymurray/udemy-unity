﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public GameObject m_projectile;
	public float m_speed;
	public float m_padding;
	public float m_projectileSpeed;
	public float m_firingRate;

	private float m_minX;
	private float m_maxX;

	void Start ()
	{
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftmost = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distance));
		Vector3 rightmost = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distance));

		m_minX = leftmost.x + m_padding;
		m_maxX = rightmost.x - m_padding;
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.LeftArrow) && !Input.GetKey (KeyCode.RightArrow)) {
			transform.position += Vector3.left * m_speed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.RightArrow) && !Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += Vector3.right * m_speed * Time.deltaTime;
		}

		float newX = Mathf.Clamp (transform.position.x, m_minX, m_maxX);

		transform.position = new Vector3 (newX, transform.position.y, transform.position.z);

		if (Input.GetKeyDown (KeyCode.Space)) {
			InvokeRepeating ("Fire", 0.000001f, m_firingRate);
		}

		if (Input.GetKeyUp (KeyCode.Space)) {
			CancelInvoke("Fire");
		}
	}

	void Fire() {
		GameObject projectile = Instantiate (m_projectile, transform.position, Quaternion.identity) as GameObject;
		projectile.rigidbody2D.velocity = Vector3.up * m_projectileSpeed;
	}
}
