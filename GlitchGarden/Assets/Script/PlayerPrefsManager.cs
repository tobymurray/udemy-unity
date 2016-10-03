﻿using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour
{

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	const int TRUE = 1;
	
	public static void SetMasterVolume (float volume)
	{
		if (volume < 0f || volume > 1f) {
			Debug.LogError ("Master volume (" + volume + ") out of range");
			return;
		}

		PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
	}

	public static float GetMasterVolume ()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel (int level)
	{
		if (level > Application.levelCount - 1) {
			Debug.LogError ("Cannot unlock level " + level + " which is not in the build order");
			return;
		}

		PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), TRUE); 
	}

	public static bool IsLevelUnlocked (int level)
	{
		if (level > Application.levelCount - 1) {
			Debug.LogError ("Cannot check level " + level + ", as it is not in the build order");
			return false;
		}

		return PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ()) == TRUE;
	}

	public static void SetDifficulty (int difficulty)
	{
		if (1 > difficulty || difficulty > 3) {
			Debug.LogError ("Difficulty (" + difficulty + ") out of range");
			return;
		}
		
		PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
	}

	public static float GetDifficulty ()
	{
		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
	}
}
