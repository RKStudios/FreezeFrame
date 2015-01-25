﻿using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {

	public bool doorTrigger;
	bool rotateRight = false;
	bool rotateLeft = false;
	public Player playerObject;
	public float time;

	// Use this for initialization
	void Start () {
		doorTrigger = false;
	}
 
	void OnCollisionEnter2D(Collision2D other)
	{

		if (doorTrigger == false){
			doorTrigger = true;

			if (other.transform.tag == "Player" && playerObject.horizontalMovement < 0  ) {

				rotateRight = true;


				//gameObject.collider.enabled = false;

				//transform.Rotate(new Vector3(0,0,-60) );
				//gameObject.collider.enabled = true;

			}
			else if (other.transform.tag == "Player" && playerObject.horizontalMovement > 0 ){

				rotateLeft = true;

				//gameObject.collider.enabled = false;

				//transform.Rotate(new Vector3(0,0,60)  );
				//gameObject.collider.enabled = true;
			}
		
		}
		else {
/*
		else if (doorTrigger == true){
			doorTrigger = false;

			if (other.transform.tag == "Player" && playerObject.horizontalMovement < 0  ) {
				
				transform.Rotate(new Vector3(0,0,60)  );
				gameObject.collider.enabled = false;

				//transform.Rotate(new Vector3(0,0,-60) );
				//gameObject.collider.enabled = true;
			}
			else if (other.transform.tag == "Player" && playerObject.horizontalMovement > 0 ){
				
				transform.Rotate(new Vector3(0,0,-60));
				gameObject.collider.enabled = false;

				//transform.Rotate(new Vector3(0,0,60)  );
				//gameObject.collider.enabled = true;
			}
		}
		
*/		
		return;
		}
	}

	void Update(){

		//Debug.Log (rotateLeft);
		//Debug.Log (rotateRight);

		if (rotateRight == true){
			transform.Rotate(new Vector3(0,0,-15)  );
			//if (transform.eulerAngles == new Vector3(0,0,-15)){

				rotateRight = false;

			//}
		}

		if (rotateLeft == true){

			transform.Rotate(new Vector3(0,0,15));
			//	if (transform.eulerAngles == new Vector3(0,0,15)){

				rotateLeft = false;
	
			//}	
		}


	
	}


}
