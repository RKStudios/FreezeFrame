using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject target;
	public float adjustTarget;
	bool jump;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (!jump)
		{
			if (other.gameObject.tag == "Player" && target != null)
			{
					target.GetComponent<Teleport>().jump = true;
					other.gameObject.transform.position = new Vector3 (target.transform.position.x, 
			                                                  			target.transform.position.y + adjustTarget, 0);
			}
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.tag == "Player") {
			jump = false;
		}
	}
}
