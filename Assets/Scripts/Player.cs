using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	int speed = 1000;
	int jumpPower = 500;
	float horizontalMovement = 0;
	bool isPlayerMoving = false;

	// Use this for initialization
	void Start()
	{
	
	}

	void FixedUpdate()
	{

		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
		{
			isPlayerMoving = true;
		}

		horizontalMovement = Input.GetAxis("Horizontal");

		Debug.Log(horizontalMovement);
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rigidbody2D.AddForce(Vector2.up * jumpPower);
		}

		rigidbody2D.AddForce(Vector2.right * horizontalMovement * Time.deltaTime * speed);

	}

	// Update is called once per frame
	void Update() 
	{

	}
}
