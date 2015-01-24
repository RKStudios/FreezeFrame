using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject deathParticles;
	private Vector2 spawn;

	int speed = 10;
	int jumpSpeed = 8;
	float horizontalMovement = 0;
	float verticalMovement = 0;
	bool canJump = false;
	bool wasVerticalSpeedZero = false;

	// Use this for initialization
	void Start()
	{
		spawn = transform.position;
	}

	public bool GetCanJump()
	{
		return canJump;
	}

	public void SetCanJump(bool value)
	{
		canJump = value;
	}

	public bool GetWasVerticalSpeedZero()
	{
		return wasVerticalSpeedZero;
	}
	
	public void SetWasVerticalSpeedZero(bool value)
	{
		wasVerticalSpeedZero = value;
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

	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log ("ON COLLISION " + other.gameObject.name + "   " + other.gameObject.tag);
		if (other.transform.tag == "Trap") {
			Instantiate (deathParticles, transform.position, Quaternion.identity);
			transform.position = spawn;
		}
	}

	//stretching????
	void Stretch()
	{	//ambiguous error here
		//transform.localScale += new Vector2(0.1F, 0);
	}
}
