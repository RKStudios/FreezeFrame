using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Bounds bounds;

	}
	
	// Update is called once per frame
	void Update () {
		//transform.RotateAround(Collider.bounds.center, Vector3.forward, 20 * Time.deltaTime
		//Debug.Log ("TRYING TO UPDATE");
		transform.Rotate(new Vector3(0,0,30) * Time.deltaTime);
	}
}
