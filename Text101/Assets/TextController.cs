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
			m_text.text = "You are in a prison cell, and you want to escape. There are " +
						  "some dirty sheets on the bed, a mirror on the wall, and a door " +
					      "is locked from the outside.\n\n" +
						  "Press S to view Sheets, M to view Mirror and L to view Lock";
		}
	}
}
