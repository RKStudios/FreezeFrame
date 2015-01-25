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
			if(door != null)
			{
				door.GetComponent<BoxCollider2D>().enabled = false;
				door.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
				LineRenderer line = door.AddComponent<LineRenderer>();
				line.SetPosition(0, this.transform.position);
				line.SetPosition(1, door.transform.position);
				line.SetWidth(0.1f, 0.1f);

			}
		}

		foreach(GameObject door in doors)
		{
			if(door != null)
			{
				LineRenderer line = door.AddComponent<LineRenderer>();
				line.SetPosition(0, this.transform.position);
				line.SetPosition(1, door.transform.position);
				line.SetWidth(0.1f, 0.1f);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player" || other.gameObject.tag == "FrozenPlayer")
		{
			if(!playerObjects.Contains(other.gameObject))
			{
				playerObjects.Add(other.gameObject);
			}
			foreach(GameObject door in reverseDoors)
			{
				if(door != null)
				{
					door.GetComponent<BoxCollider2D>().enabled = true;
					door.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
				}
			}

			foreach(GameObject door in doors)
			{
				if(door != null)
				{
					door.GetComponent<BoxCollider2D>().enabled = false;
					door.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
				}
			}
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player" || other.gameObject.tag == "FrozenPlayer")
		{
			playerObjects.Remove(other.gameObject);
		}

		if(playerObjects.Count == 0)
		{
			foreach(GameObject door in reverseDoors)
			{
				if(door != null)
				{
					door.GetComponent<BoxCollider2D>().enabled = false;
					door.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
				}
			}
			
			foreach(GameObject door in doors)
			{
				if(door != null)
				{
					door.GetComponent<BoxCollider2D>().enabled = true;
					door.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);
				}
			}
		}
	}


}
