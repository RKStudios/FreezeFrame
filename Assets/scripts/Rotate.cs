using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public bool isRotatingRight = false;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		if (isRotatingRight == false){
			transform.Rotate(new Vector3(0,0,25) * Time.deltaTime);
		}
		else if (isRotatingRight == true){
			transform.Rotate(new Vector3(0,0,-25) * Time.deltaTime);
		}

	}
}
