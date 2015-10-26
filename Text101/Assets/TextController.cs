using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text m_text;

	// Use this for initialization
	void Start () {
		m_text.text = "Hello World";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			m_text.text = "Space key pressed";
		}
	}
}
