using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	public int levelToLoad;
	void OnTriggerStay2D(Collider2D other) {
		if (Input.GetButtonDown ("Action")) {
			print ("Select 1");
			Application.LoadLevel ("Level " + levelToLoad.ToString ());
		}
	}
}
