using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public float m_minX;
	public float m_maxX;
	public bool m_autoPlay = false;
	private Ball m_ball;

	// Use this for initialization
	void Start () {
		m_ball = GameObject.FindObjectOfType<Ball> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!m_autoPlay) {
			MoveWithMouse ();
		} else {
			AutoPlay();
		}
	}

	void MoveWithMouse() {
		float mouseXInBlocks = Input.mousePosition.x / Screen.width * 16;
		this.transform.position = new Vector3 (Mathf.Clamp(mouseXInBlocks, m_minX, m_maxX), this.transform.position.y);
	}

	void AutoPlay() {
		Vector3 ballPosition = m_ball.transform.position;
		Vector3 paddlePosition = new Vector3 (Mathf.Clamp (ballPosition.x, m_minX, m_maxX), this.transform.position.y, 0f);

		this.transform.position = paddlePosition;
	}
}
