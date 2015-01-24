using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public Lever leverObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(leverObject.doorTrigger == false)
		{
			return;
		}
		else if(leverObject.doorTrigger == true)
		
			transform.position = new Vector3( 0, -15, 0);
		}
	}
}
