using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

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
		this.transform.position = new Vector3 (Mathf.Clamp(mouseXInBlocks, 0.5f, 15.5f), this.transform.position.y);
	}

	void AutoPlay() {
		Vector3 ballPosition = m_ball.transform.position;
		Vector3 paddlePosition = new Vector3 (Mathf.Clamp (ballPosition.x, 0.5f, 15.5f), this.transform.position.y, 0f);

		this.transform.position = paddlePosition;
	}
}
