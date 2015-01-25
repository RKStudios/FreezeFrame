using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {
	void OnTriggerStay2D(Collider2D other) {
		if (Input.GetButtonDown ("Action")) {
			print ("Level Select");
			Application.LoadLevel ("LevelSelector 1");
		}
	}
}
