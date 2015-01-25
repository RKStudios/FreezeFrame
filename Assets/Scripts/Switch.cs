using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Switch : MonoBehaviour {

	public GameObject door;
	List<GameObject> playerObjects;
	public bool reverse;

	// Use this for initialization
	void Start () {
		playerObjects = new List<GameObject>();
		if(reverse)
		{
			door.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (other.gameObject + "  " + other.gameObject.tag);
		if(other.gameObject.tag == "Player" || other.gameObject.tag == "FrozenPlayer")
		{
			if(!playerObjects.Contains(other.gameObject))
			{
				playerObjects.Add(other.gameObject);
			}
			if(reverse)
			{
				door.gameObject.SetActive(true);
			}
			else
			{
				door.gameObject.SetActive(false);
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log (other.gameObject + "  " + other.gameObject.tag);
		if(other.gameObject.tag == "Player" || other.gameObject.tag == "FrozenPlayer")
		{
			playerObjects.Remove(other.gameObject);
		}

		if(playerObjects.Count == 0)
		{
			if(reverse)
			{
				door.gameObject.SetActive(false);
			}
			else
			{
				door.gameObject.SetActive(true);
			}
		}
	}


}
