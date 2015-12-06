﻿using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mouseXInBlocks = Input.mousePosition.x / Screen.width * 16;

		this.transform.position = new Vector3 (Mathf.Clamp(mouseXInBlocks, 0.5f, 15.5f), this.transform.position.y);
	}
}
