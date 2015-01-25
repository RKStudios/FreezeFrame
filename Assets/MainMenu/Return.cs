using UnityEngine;
using System.Collections;

public class Return : MonoBehaviour {
	void OnTriggerStay2D(Collider2D other) {
		if (Input.GetButtonDown ("Action")) {
			print ("Main Menu");
			Application.LoadLevel ("MainMenu");
		}
	}
}
