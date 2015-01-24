using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject deathParticles;
	public GameObject frozenPlayer;
	private Vector2 spawn;

	int speed = 10;
	int jumpSpeed = 8;
	public float horizontalMovement = 0;
	public float verticalMovement = 0;
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

		if(Input.GetButtonDown("FreezeFrame"))
		{
			FreezeFrame();
		}

		rigidbody2D.velocity = new Vector2(horizontalMovement * speed, verticalMovement);

	}

	// Update is called once per frame
	void Update() 
	{
		if (transform.position.y < -5) {
			Die ();
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.transform.tag == "Trap") {
			Die ();		
		}
	}

	//stretching????
	void Stretch()
	{	//ambiguous error here
		//transform.localScale += new Vector2(0.1F, 0);
	}

	void FreezeFrame()
	{
		Vector3 positionToSpawn = transform.position;
		transform.position = spawn;
		Instantiate(frozenPlayer, positionToSpawn, Quaternion.Euler(0, 0, 0));
	}

	void Die() {
		Instantiate (deathParticles, transform.position, Quaternion.Euler (270, 0, 0));
		transform.position = spawn;
	}
}
