using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {
	void OnTriggerStay2d(Collider2D other) {
		if (Input.GetButtonDown ("Action")) {
			print ("Quit");
			Application.Quit();
		}
	}
}
