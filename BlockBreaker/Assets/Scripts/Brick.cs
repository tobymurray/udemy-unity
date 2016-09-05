using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	public static int s_breakableCount = 0;
	public int m_maxHits;
	public Sprite[] m_hitSprites;
	public AudioClip m_crack;
	public GameObject m_smoke;

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
		AudioSource.PlayClipAtPoint (m_crack, transform.position, 0.25f);
	}

	void HandleHits() {
		m_timesHit++;
		if (m_timesHit >= m_maxHits) {
			PuffSmoke();
			s_breakableCount--;
			m_levelManager.BrickDestroyed();
			Destroy (gameObject);
		} else {
			LoadSprites();
		}
	}

	void PuffSmoke() {
		GameObject smokePuff = Instantiate (m_smoke, gameObject.transform.position, Quaternion.identity) as GameObject;
		smokePuff.particleSystem.startColor = gameObject.GetComponent<SpriteRenderer>().color;
	}

	void LoadSprites() {
		int spriteIndex = m_timesHit - 1;
		if (m_hitSprites [spriteIndex]) {
			this.GetComponent<SpriteRenderer> ().sprite = m_hitSprites [spriteIndex];
		} else {
			Debug.LogError ("Unable to load sprite with index: " + spriteIndex);
		}
	}
	
}
