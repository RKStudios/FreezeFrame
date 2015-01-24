using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	int speed = 10;
	int jumpSpeed = 8;
	float horizontalMovement = 0;
	float verticalMovement = 0;
	bool canJump = false;
	bool wasVerticalSpeedZero = false;

	// Use this for initialization
	void Start()
	{
	
	}

	void FixedUpdate()
	{
		horizontalMovement = Input.GetAxis("Horizontal");
		verticalMovement = rigidbody2D.velocity.y;

		if(verticalMovement == 0 && !wasVerticalSpeedZero)
		{
			wasVerticalSpeedZero = true;
		}
		else if(verticalMovement == 0 && wasVerticalSpeedZero)
		{
			canJump = true;
		}

		if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && canJump)
		{
			verticalMovement = jumpSpeed;
			canJump = false;
			wasVerticalSpeedZero = false;
		}

		rigidbody2D.velocity = new Vector2(horizontalMovement * speed, verticalMovement);

	}

	// Update is called once per frame
	void Update() 
	{

	}
}
