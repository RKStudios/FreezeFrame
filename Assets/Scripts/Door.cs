using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	public int fallSpeed = 5;

	public Lever leverObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(leverObject.doorTrigger == true){ 
		
			transform.position = transform.position - new Vector3( 0, fallSpeed, 0);
			if (transform.position == new Vector3(0, fallSpeed, 0)){
				leverObject.doorTrigger = false;
			}
		}
	}
}
