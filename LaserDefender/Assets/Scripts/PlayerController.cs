using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

	public float m_speed;

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.LeftArrow) && !Input.GetKey (KeyCode.RightArrow)) {
			transform.position += new Vector3 (-m_speed * Time.deltaTime, 0, 0);
		} else if (Input.GetKey (KeyCode.RightArrow) && !Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += new Vector3 (m_speed * Time.deltaTime, 0, 0);
		}
	}
}
