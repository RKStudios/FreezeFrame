﻿using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
	void OnTriggerStay2D(Collider2D other) {
		if (Input.GetButtonDown ("Action")) {
			print ("New Game");
			Application.LoadLevel ("Level 1");
		}
	}
}
