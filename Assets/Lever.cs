using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) 
	{
/*		if (other.tag == "Player")
		{
			return;
		}
*/
		transform.Rotate(new Vector3(0,0,150) /* * Time.deltaTime */);

	}
}
