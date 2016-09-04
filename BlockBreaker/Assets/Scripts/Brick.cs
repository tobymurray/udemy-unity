using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public int m_maxHits;
	public Sprite[] m_hitSprites;

	private int m_timesHit;
	private LevelManager m_levelManager;

	// Use this for initialization
	void Start () {
		m_timesHit = 0;
		m_levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision2D) {
		bool isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			HandleHits ();
		}
	}

	void HandleHits() {
		m_timesHit++;
		if (m_timesHit >= m_maxHits) {
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
