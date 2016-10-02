using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeIn : MonoBehaviour
{

	public float m_fadeInTime;
	private Image m_fadePanel;
	private Color m_currentColor = Color.black;

	// Use this for initialization
	void Start ()
	{
		m_fadePanel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.timeSinceLevelLoad < m_fadeInTime) {
			float alphaChange = Time.deltaTime / m_fadeInTime;
			m_currentColor.a -= alphaChange;
			m_fadePanel.color = m_currentColor;
		} else {
			gameObject.SetActive (false);
		}
	}
}
