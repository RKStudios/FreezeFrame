using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public GameObject deathParticles;
	public GameObject frozenPlayer;
	private Vector2 spawn;
	List<GameObject> frozenPlayers;

	public int speed = 10;
	public int jumpSpeed = 15;
	public float horizontalMovement = 0;
	public float verticalMovement = 0;
	bool canJump = false;
	bool wasVerticalSpeedZero = false;

	// Use this for initialization
	void Start()
	{
		spawn = transform.position;
		frozenPlayers = new List<GameObject>(5);
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

		if (Input.GetKeyDown (KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
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
		if (transform.position.y < -50) {
			Die ();
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.transform.tag == "Trap") {
			Die ();		
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.tag == "Checkpoint" && col.transform.particleSystem.startColor == new Color(1, 0, 0))
		{
			spawn = col.transform.position;
		}
	}

	//stretching????
	void Stretch()
	{	//ambiguous error here
		//transform.localScale += new Vector2(0.1F, 0);
	}

	void FreezeFrame()
	{
		if(frozenPlayers.Count < 5)
		{
			Vector3 positionToSpawn = transform.position;
			transform.position = spawn;
			GameObject frozenPlayerGO = Instantiate(frozenPlayer, positionToSpawn, Quaternion.Euler(0, 0, 0)) as GameObject;
			frozenPlayers.Add(frozenPlayerGO);
		}
		else
		{
			frozenPlayers[0].GetComponent<FrozenPlayer>().Die();
			frozenPlayers.RemoveAt(0);
			Vector3 positionToSpawn = transform.position;
			transform.position = spawn;
			GameObject frozenPlayerGO = Instantiate(frozenPlayer, positionToSpawn, Quaternion.Euler(0, 0, 0)) as GameObject;
			frozenPlayers.Add(frozenPlayerGO);
		}
	}

	void Die() {
		Instantiate (deathParticles, transform.position, Quaternion.Euler (270, 0, 0));
		transform.position = spawn;
		for(int i = 0; i < frozenPlayers.Count; ++i)
		{
			frozenPlayers[i].GetComponent<FrozenPlayer>().Die();
			frozenPlayers.RemoveAt(i);
		}

	}
}
