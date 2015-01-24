using UnityEngine;
using System.Collections;

public class HoldPlayer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.transform.parent = gameObject.transform;
			col.gameObject.GetComponent<Player>().SetCanJump(true);
			col.gameObject.GetComponent<Player>().SetWasVerticalSpeedZero(true);
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player")
		{
			col.transform.parent = null;
			col.gameObject.GetComponent<Player>().SetCanJump(false);
			col.gameObject.GetComponent<Player>().SetWasVerticalSpeedZero(false);
		}
	}
}
