using UnityEngine;
using System.Collections;

public class MoreLevels : MonoBehaviour {
	public int selectorToLoad;
	void OnTriggerStay2D(Collider2D other) {
		if (Input.GetButtonDown ("Action")) {
			print ("Select");
			Application.LoadLevel ("LevelSelector " + selectorToLoad.ToString ());
		}
	}
}
