using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public bool isRotatingRight = false;

	// Use this for initialization
	void Start () {


	}

	void OnCollisionEnter2D(Collision2D other)
	{
	
		if (other.transform.tag == "Gear" ) {
			isRotatingRight = true;
		}

		
	}
	// Update is called once per frame
	void Update () {

		if (isRotatingRight == false){
			transform.Rotate(new Vector3(0,0,30) * Time.deltaTime);
		}
		else if (isRotatingRight == true){
			transform.Rotate(new Vector3(0,0,-30) * Time.deltaTime);
		}

	}
}
