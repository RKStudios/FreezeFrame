using UnityEngine;
using System.Collections;

public class CheckpointReached : MonoBehaviour 
{
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			gameObject.particleSystem.startColor = Color.green;
			col.gameObject.GetComponent<Player>().SetCheckpoint(transform.position);
		}
	}
}
