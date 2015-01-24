﻿using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour {

	public bool doorTrigger = false;
	public Player playerObject;
	public float time;

	// Use this for initialization
	void Start () {
	
	}
 
	void OnCollisionEnter2D(Collision2D other)
	{

		if (doorTrigger == false){
			doorTrigger = true;

			if (other.transform.tag == "Player" && playerObject.horizontalMovement < 0  ) {

				transform.Rotate(new Vector3(0,0,60)  );
				//gameObject.collider.enabled = false;

				//transform.Rotate(new Vector3(0,0,-60) );
				//gameObject.collider.enabled = true;

			}
			else if (other.transform.tag == "Player" && playerObject.horizontalMovement > 0 ){
					
				transform.Rotate(new Vector3(0,0,-60));
				//gameObject.collider.enabled = false;

				//transform.Rotate(new Vector3(0,0,60)  );
				//gameObject.collider.enabled = true;
			}
		}
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

	void Update(){
		time += Time.deltaTime;
	}


}
