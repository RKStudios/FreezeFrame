using UnityEngine;
using System.Collections;

public class FreezeBox : MonoBehaviour {
	public GameObject other;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGui() {
		GUI.Label (new Rect (10, 10, 100, 20), "Press Shift");

}
}