using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

	private Paddle m_paddle;
	private Vector3 m_vectorToBall;
	private bool m_hasStarted = false;

	// Use this for initialization
	void Start ()
	{
		m_paddle = GameObject.FindObjectOfType<Paddle>();
		m_vectorToBall = this.transform.position - m_paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!m_hasStarted) {
			// Lock the ball relative to the paddle
			this.transform.position = m_paddle.transform.position + m_vectorToBall;

			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse clicked");
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
				m_hasStarted = true;
			}
		}
	}
}
