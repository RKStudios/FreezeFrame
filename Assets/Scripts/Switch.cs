using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Switch : MonoBehaviour {

	List<GameObject> playerObjects;
	public List<GameObject> doors;
	public List<GameObject> reverseDoors;

	// Use this for initialization
	void Start () {
		playerObjects = new List<GameObject>();
		foreach(GameObject door in reverseDoors)
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
			foreach(GameObject door in reverseDoors)
			{
				door.SetActive(true);
			}

			foreach(GameObject door in doors)
			{
				door.SetActive(false);
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
			foreach(GameObject door in reverseDoors)
			{
				door.SetActive(false);
			}
			
			foreach(GameObject door in doors)
			{
				door.SetActive(true);
			}
		}
	}


}
