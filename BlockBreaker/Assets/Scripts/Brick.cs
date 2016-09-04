using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public static int s_breakableCount = 0;
	public int m_maxHits;
	public Sprite[] m_hitSprites;
	public AudioClip m_crack;

	private int m_timesHit;
	private LevelManager m_levelManager;
	private bool m_isBreakable;

	// Use this for initialization
	void Start () {
		m_timesHit = 0;
		m_levelManager = GameObject.FindObjectOfType<LevelManager> ();
		m_isBreakable = (this.tag == "Breakable");
		if (m_isBreakable) {
			s_breakableCount++;
		}
		print ("Breakble count is currently: " + s_breakableCount);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		if (m_isBreakable) {
			HandleHits ();
		}
		AudioSource.PlayClipAtPoint (m_crack, transform.position);
	}

	void HandleHits() {
		m_timesHit++;
		if (m_timesHit >= m_maxHits) {
			s_breakableCount--;
			m_levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}

	void LoadSprites() {
		int spriteIndex = m_timesHit - 1;
		if (m_hitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = m_hitSprites [spriteIndex];
			Debug.Log ("Unable to load sprite with index" + spriteIndex);
		}
	}
	
}
