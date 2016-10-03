using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour
{

	public Slider m_volumeSlider;
	public Slider m_difficultySlider;
	public LevelManager m_levelManager;
	private MusicManager m_musicManager;

	// Use this for initialization
	void Start ()
	{
		m_musicManager = GameObject.FindObjectOfType<MusicManager> ();
		m_volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		m_difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		m_musicManager.ChangeVolume ((int)m_volumeSlider.value);
	}

	public void SaveAndExit ()
	{
		PlayerPrefsManager.SetMasterVolume (m_volumeSlider.value);
		PlayerPrefsManager.SetDifficulty ((int)m_difficultySlider.value);
		m_levelManager.LoadLevel ("01a Start");
	}

	public void SetDefaults ()
	{
		m_volumeSlider.value = 0.5f;
		m_difficultySlider.value = 1f;
	}
}
