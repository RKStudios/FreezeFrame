using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerJumpCollider : MonoBehaviour {

	public List<string> groundTags;
	public Player player;
	List<GameObject> groundObjects;

	// Use this for initialization
	void Start () {
		groundObjects = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(groundTags.Contains(other.gameObject.tag))
		{
			groundObjects.Add(other.gameObject);
			player.SetCanJump(true);
		}

		if(other.gameObject.tag == "PlayerHolder")
		{
			player.gameObject.transform.parent = other.gameObject.transform;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(groundTags.Contains(other.gameObject.tag))
		{
			groundObjects.Remove(other.gameObject);
			if(groundObjects.Count == 0)
			{
				player.SetCanJump(false);
			}
		}

		Debug.Log (other.gameObject.tag);

		if(other.gameObject.tag == "PlayerHolder")
		{
			player.gameObject.transform.parent = null;
		}
	}
}
