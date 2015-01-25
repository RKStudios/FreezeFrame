using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
		void OnTriggerStay2D(Collider2D other) {
			
			if (Input.GetButtonDown ("Action")) {
				print ("Level Loader");
				Application.LoadLevel ("LevelSelector");
			}
		}
}
